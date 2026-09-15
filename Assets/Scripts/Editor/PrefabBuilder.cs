using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

/// <summary>
/// Импорт FBX из Blender → игровые префабы: материалы по слотам, коллайдеры,
/// легаси-анимации (Animation-компонент), физика.
/// </summary>
public static class PrefabBuilder
{
    private const string ModelsDir = "Assets/Art/Models";
    private const string PrefabsDir = "Assets/Art/Prefabs";

    /// <summary>Материал по имени слота модели из Blender.</summary>
    private static Material MaterialForSlot(string slotName)
    {
        switch (slotName)
        {
            case "seal_fur": return MaterialCache("seal_fur", "tex_fur_white", 0.85f, "tex_fur_n", smooth: "tex_fur_white_r");
            case "seal_fur_adult": return MaterialCache("seal_fur_adult", "tex_fur_gray", 0.85f, "tex_fur_n", smooth: "tex_fur_gray_r");
            case "seal_dark": return MaterialCache("seal_dark", null, 0.35f, null, 0f, true,
                    new Color(0.02f, 0.02f, 0.025f));
            case "seal_eye": return MaterialCache("seal_eye", "tex_eye", 0.06f, smooth: "tex_eye_r");
            case "orca_skin": return MaterialCache("orca_skin", "tex_orca", 0.6f, "tex_orca_n", smooth: "tex_orca_r");
            case "fish_skin": return MaterialCache("fish_skin", "tex_fish", 0.35f, null, 0.25f, smooth: "tex_fish_r");
            case "snow": return MaterialCache("snow", "tex_snow", 0.92f, "tex_snow_n", smooth: "tex_snow_r");
            case "ice": return MaterialCache("ice", "tex_ice", 0.4f, "tex_ice_n", smooth: "tex_ice_r");
            case "rock": case "clam": return MaterialCache("rock", "tex_rock", 0.9f, "tex_noise_n", smooth: "tex_rock_r");
            case "kelp": return MaterialCache("kelp", "tex_kelp", 0.75f, null, 0f, true);
            case "coral": return MaterialCache("coral", "tex_coral", 0.8f);
            case "sand": return MaterialCache("sand", "tex_sand", 0.95f, "tex_noise_n", smooth: "tex_sand_r");
            default: return MaterialCache("fallback", "tex_rock", 0.8f);
        }
    }

    private static readonly System.Collections.Generic.Dictionary<string, Material> _cache = new();

    private static Material MaterialCache(string key, string tex, float rough, string normal = null,
        float metal = 0f, bool dark = false, Color? tint = null, string smooth = null)
    {
        if (_cache.TryGetValue(key, out var m)) return m;
        m = MaterialBuilder.Build(key, tex, rough, normal, metal, false, tint, smooth);
        _cache[key] = m;
        return m;
    }

    /// <summary>Настроить импортер FBX: материалы по слотам + легаси-анимации.
    /// Имена клипов приходят из Blender-акций (тейков) — используем как есть.</summary>
    private static void ConfigureImporter(string modelPath, bool withLegacyClips, string[] clipNames)
    {
        var importer = AssetImporter.GetAtPath(modelPath) as ModelImporter;
        if (importer == null) return;
        // Unity 6: enum BuiltIn удалён — ImportViaMaterialDescription импортирует материалы
        // из FBX с именами слотов, RetargetMaterials затем подменяет их на наши URP-материалы.
        importer.materialLocation = ModelImporterMaterialLocation.InPrefab; // Unity 6.4+: встроенные материалы FBX

        if (withLegacyClips)
        {
            var clips = importer.defaultClipAnimations;
            for (int i = 0; i < clips.Length; i++)
            {
                string n = clips[i].name;
                bool once = n.Contains("Lunge") || n.Contains("Bark") || n.Contains("Eat");
                // Unity 6: ModelImporterClipAnimation.legacy удалён — легаси-флаг ставится
                // напрямую на AnimationClip (см. BuildSeal/BuildOrca: clip.legacy = true).
                clips[i].loopTime = !once;
            }
            importer.clipAnimations = clips;
            importer.importAnimation = true;
        }
        else
        {
            importer.importAnimation = false;
        }
        importer.SaveAndReimport();
    }

    /// <summary>Переназначить встроенные материалы по слотам на наши URP-материалы.</summary>
    private static void RetargetMaterials(GameObject root)
    {
        foreach (var renderer in root.GetComponentsInChildren<Renderer>(true))
        {
            var mats = renderer.sharedMaterials;
            for (int i = 0; i < mats.Length; i++)
            {
                if (mats[i] == null) continue;
                mats[i] = MaterialForSlot(mats[i].name);
            }
            renderer.sharedMaterials = mats;
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            renderer.receiveShadows = true;
        }
    }

    private static GameObject SavePrefab(GameObject root, string name)
    {
        Directory.CreateDirectory(PrefabsDir);
        var path = $"{PrefabsDir}/{name}.prefab";
        var existing = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (existing != null)
        {
            var saved = PrefabUtility.SaveAsPrefabAsset(root, path);
            Object.DestroyImmediate(root);
            return saved;
        }
        var prefab = PrefabUtility.SaveAsPrefabAsset(root, path);
        Object.DestroyImmediate(root);
        return prefab;
    }

    // ---------- Префабы ----------
    public static GameObject BuildSeal(string modelFile, string prefabName, string[] clips)
    {
        string modelPath = $"{ModelsDir}/{modelFile}";
        ConfigureImporter(modelPath, clips != null && clips.Length > 0, clips);

        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogError($"[Prefabs] {modelPath} not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = prefabName;

        RetargetMaterials(root);

        // Animation-компонент (Unity 6 ModelImporter уже добавляет Animation на корень FBX)
        if (clips != null && clips.Length > 0)
        {
            var anim = root.GetComponent<Animation>();
            if (anim == null) anim = root.AddComponent<Animation>(); // fake-null-safe (не ??)
            anim.playAutomatically = true;
            foreach (var clipName in clips)
            {
                var clip = AssetDatabase.LoadAssetAtPath<AnimationClip>($"{modelPath}/{clipName}");
                if (clip != null)
                {
                    clip.legacy = true;
                    EditorUtility.SetDirty(clip);
                    anim.AddClip(clip, clipName);
                }
            }
        }

        // Физика
        var col = root.AddComponent<CapsuleCollider>();
        col.radius = 0.42f;
        col.height = 1.55f;
        col.direction = 2; // вдоль тела (Z после FBX-конверсии)
        col.center = new Vector3(0, 0, 0.1f);
        var rb = root.AddComponent<Rigidbody>();
        rb.mass = 1f;
        rb.useGravity = true;
        root.layer = LayerMask.NameToLayer("Player");

        return SavePrefab(root, prefabName);
    }

    public static GameObject BuildOrca()
    {
        string modelPath = $"{ModelsDir}/orca.fbx";
        ConfigureImporter(modelPath, true, new[] { "OrcaCruise", "OrcaChase", "OrcaLunge" });

        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogError("[Prefabs] orca.fbx not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = "Orca";

        RetargetMaterials(root);

        var anim = root.GetComponent<Animation>();
        if (anim == null) anim = root.AddComponent<Animation>(); // уже есть от импортёра; fake-null-safe (не ??)
        anim.playAutomatically = true;
        foreach (var clipName in new[] { "OrcaCruise", "OrcaChase", "OrcaLunge" })
        {
            var clip = AssetDatabase.LoadAssetAtPath<AnimationClip>($"{modelPath}/{clipName}");
            if (clip != null)
            {
                clip.legacy = true;
                EditorUtility.SetDirty(clip);
                anim.AddClip(clip, clipName);
            }
        }

        var col = root.AddComponent<CapsuleCollider>();
        col.radius = 0.9f;
        col.height = 5.4f;
        col.direction = 2;
        col.isTrigger = false;
        var rb = root.AddComponent<Rigidbody>();
        rb.mass = 8f;
        rb.useGravity = false;
        root.layer = LayerMask.NameToLayer("Creature");
        root.AddComponent<OrcaAgent>();
        root.GetComponent<OrcaAgent>().anim = anim;

        return SavePrefab(root, "Orca");
    }

    public static GameObject BuildFish()
    {
        string modelPath = $"{ModelsDir}/herring.fbx";
        ConfigureImporter(modelPath, false, null);
        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogError("[Prefabs] herring.fbx not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = "Herring";
        RetargetMaterials(root);
        // Рыба используется через DrawMeshInstanced — префаб только хранит меш/материал
        var school = root.AddComponent<FishSchool>();
        var smr = root.GetComponentInChildren<MeshRenderer>();
        var mf = root.GetComponentInChildren<MeshFilter>();
        if (school != null && mf != null)
        {
            school.fishMesh = mf.sharedMesh;
            school.fishMaterial = smr != null ? smr.sharedMaterial : null;
        }
        return SavePrefab(root, "Herring");
    }

    public static GameObject BuildStaticProp(string modelFile, string prefabName, bool boxCollider,
        bool iceLayer = false, bool addIceFloe = false, bool addHole = false)
    {
        string modelPath = $"{ModelsDir}/{modelFile}";
        ConfigureImporter(modelPath, false, null);
        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogError($"[Prefabs] {modelPath} not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = prefabName;
        RetargetMaterials(root);

        var col = root.AddComponent<BoxCollider>();
        col.isTrigger = false;

        if (iceLayer) root.layer = LayerMask.NameToLayer("Ice");
        if (addIceFloe)
        {
            root.AddComponent<IceFloe>();
            if (addHole)
            {
                var holeGo = new GameObject("BreathingHole");
                holeGo.transform.SetParent(root.transform, false);
                holeGo.transform.localPosition = new Vector3(0, 0.4f, 0);
                holeGo.AddComponent<BreathingHole>().radius = 1.3f;
            }
        }
        return SavePrefab(root, prefabName);
    }

    public static GameObject BuildKrillPickup(Material krillMat)
    {
        var root = new GameObject("KrillPickup");
        var col = root.AddComponent<SphereCollider>();
        col.radius = 1.4f;
        col.isTrigger = true;
        root.AddComponent<FoodPickup>().type = FoodType.Krill;
        root.layer = LayerMask.NameToLayer("Food");

        var meshGo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        meshGo.name = "Core";
        Object.DestroyImmediate(meshGo.GetComponent<Collider>());
        meshGo.transform.SetParent(root.transform, false);
        meshGo.transform.localScale = Vector3.one * 0.5f;
        var mr = meshGo.GetComponent<MeshRenderer>();
        var mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        mat.enableInstancing = true; // консистентно с остальными материалами
        mat.SetColor("_BaseColor", new Color(0.7f, 0.95f, 1f, 0.8f));
        mat.SetFloat("_Smoothness", 0.7f);
        AssetDatabase.CreateAsset(mat, "Assets/Art/Materials/krill_glow.mat");
        mr.sharedMaterial = mat;

        // Свечение-частицы
        var psGo = new GameObject("Glow");
        psGo.transform.SetParent(root.transform, false);
        var ps = psGo.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.startColor = new Color(0.6f, 0.95f, 1f, 0.5f);
        main.startSize = 0.12f;
        main.startLifetime = 2f;
        main.simulationSpace = ParticleSystemSimulationSpace.Local;
        var em = ps.emission;
        em.rateOverTime = 14f;
        var sh = ps.shape;
        sh.shapeType = ParticleSystemShapeType.Sphere;
        sh.radius = 1.2f;

        return SavePrefab(root, "KrillPickup");
    }

    // ---------- Community (CC0) модели ----------
    // Источники: Assets/Art/Models/Community/ATTRIBUTION.md
    //  whale.fbx  — OGA "Whale (lowpoly)" CC0 (swim-цикл)
    //  fish_a/b/c — Quaternius "Animated Fish" CC0 (Swim-циклы)

    /// <summary>Один URP-материал на все рендереры (lowpoly без слотов).</summary>
    private static void RetargetCommunityMaterials(GameObject root, Material mat)
    {
        foreach (var renderer in root.GetComponentsInChildren<Renderer>(true))
        {
            var mats = new Material[renderer.sharedMaterials.Length];
            for (int i = 0; i < mats.Length; i++) mats[i] = mat;
            renderer.sharedMaterials = mats;
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            renderer.receiveShadows = true;
        }
    }

    /// <summary>Нормализовать длину модели по renderer bounds (модели бывают огромными).</summary>
    private static void NormalizeVisualScale(GameObject root, float targetLength)
    {
        var renderers = root.GetComponentsInChildren<Renderer>();
        if (renderers.Length == 0) return;
        var bounds = renderers[0].bounds;
        foreach (var r in renderers) bounds.Encapsulate(r.bounds);
        float len = Mathf.Max(bounds.size.x, bounds.size.y, bounds.size.z);
        if (len > 0.0001f) root.transform.localScale *= targetLength / len;
    }

    /// <summary>Все клипы FBX → Animation (legacy), playAutomatically, первый — default.
    /// ВАЖНО: не использовать `??` для Unity-объектов — GetComponent может вернуть
    /// fake-null обёртку после реимпорта (MissingComponentException). Только == null.</summary>
    private static void AddCommunityAnimation(string modelPath, GameObject root)
    {
        var anim = root.GetComponent<Animation>();
        if (anim == null) anim = root.AddComponent<Animation>();
        if (anim == null) { Debug.LogWarning($"[Prefabs] No Animation component on {root.name}"); return; }
        anim.playAutomatically = true;
        AnimationClip best = null, first = null;
        foreach (var obj in AssetDatabase.LoadAllAssetsAtPath(modelPath))
        {
            if (obj is AnimationClip clip && !clip.name.StartsWith("__preview"))
            {
                if (clip.length < 0.01f) continue; // вырожденные клипы (PointAction.008)
                clip.legacy = true;
                EditorUtility.SetDirty(clip);
                if (anim.GetClip(clip.name) == null) anim.AddClip(clip, clip.name);
                if (first == null) first = clip;
                if (best == null && clip.name.ToLowerInvariant().Contains("swim")) best = clip;
            }
        }
        if (anim.clip == null && best != null) anim.clip = best;
        if (anim.clip == null && first != null) anim.clip = first;
    }

    public static GameObject BuildCommunityWhale()
    {
        string modelPath = $"{ModelsDir}/Community/whale.fbx";
        ConfigureImporter(modelPath, true, null);
        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogWarning("[Prefabs] Community whale.fbx not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = "AmbientWhale";
        // Тёмный окрас касатки (стилизованная ambient-косатка)
        RetargetCommunityMaterials(root, MaterialCache("community_whale", null, 0.5f,
            tint: new Color(0.13f, 0.16f, 0.21f)));
        AddCommunityAnimation(modelPath, root);
        NormalizeVisualScale(root, 7.5f);
        return SavePrefab(root, "AmbientWhale");
    }

    public static GameObject BuildCommunityFish(string modelFile, string prefabName, Color tint)
    {
        string modelPath = $"{ModelsDir}/Community/{modelFile}";
        ConfigureImporter(modelPath, true, null);
        var src = AssetDatabase.LoadAssetAtPath<GameObject>(modelPath);
        if (src == null) { Debug.LogWarning($"[Prefabs] Community {modelFile} not found"); return null; }
        var root = (GameObject)PrefabUtility.InstantiatePrefab(src);
        root.name = prefabName;
        RetargetCommunityMaterials(root, MaterialCache(prefabName.ToLowerInvariant(), null, 0.4f, tint: tint));
        AddCommunityAnimation(modelPath, root);
        NormalizeVisualScale(root, 0.85f);
        return SavePrefab(root, prefabName);
    }
}
