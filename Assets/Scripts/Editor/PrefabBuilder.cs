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
            case "snow": return MaterialCache("snow", "tex_snow", 0.92f, "tex_noise_n", smooth: "tex_snow_r");
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

        // Animation-компонент
        if (clips != null && clips.Length > 0)
        {
            var anim = root.AddComponent<Animation>();
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

        var anim = root.AddComponent<Animation>();
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
}
