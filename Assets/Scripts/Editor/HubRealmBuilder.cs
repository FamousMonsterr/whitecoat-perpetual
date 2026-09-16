using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Whitecoat.World;

/// <summary>
/// Строит зоны Большого Мира внутри сцены Main.unity (детерминированно,
/// вызывается SceneBuilder'ом перед сохранением — CI-safe):
///   • Тёплая Бухта (хаб, offset +2500/+2500): ледяной берег, маяк, арки-порталы,
///     БИП-7 (робот Fab), жемчужные дорожки;
///   • Ледяные Сады (реалм-риф, offset −2500/0): кораллы Fab, жемчуг,
///     Поющая Раковина, обратный портал.
/// Открытое Море (origin) остаётся процедурным; у спавна — возвратный портал в хаб.
/// Ассеты без роли не ставим (DesignDocs/03). Пакет «корабль» встанет сюда позже.
/// </summary>
public static class HubRealmBuilder
{
    private const float CoveX = 2500f, CoveZ = 2500f;
    private const float GardenX = -2500f, GardenZ = 0f;

    // Детерминированный генератор раскладок
    private static System.Random _rng;

    [MenuItem("Whitecoat/Build Realms (into open scene)", priority = 1)]
    public static void BuildMenu()
    {
        var player = GameObject.Find("Player");
        BuildInto(player ? player.transform : null);
        AssetDatabase.SaveAssets();
    }

    /// <summary>Вызывается из SceneBuilder.EnsureBuilt (сцена открыта, не сохранена).</summary>
    public static void BuildInto(Transform player)
    {
        _rng = new System.Random(20260916); // фиксированный сид — детерминизм CI
        var rootRealms = new GameObject("BigWorld");
        Undo.RegisterCreatedObjectUndo(rootRealms, "Build BigWorld");

        BuildWarmCove(rootRealms.transform);
        BuildIceGardens(rootRealms.transform);
        BuildOpenSeaReturn(rootRealms.transform);
        BuildRealmSystems(rootRealms.transform, player);

        Debug.Log("[HubRealmBuilder] BigWorld zones built (WarmCove, IceGardens, OpenSea portal)");
    }

    // ---------------------------------------------------------------- хаб
    private static void BuildWarmCove(Transform parent)
    {
        var cove = new GameObject("Realm_WarmCove");
        cove.transform.SetParent(parent, false);
        cove.transform.position = new Vector3(CoveX, 0f, CoveZ);

        // Ледяное плато (диск, верх на +0.4 — Белёк может выползти на лёд)
        var ice = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        ice.name = "CoveIceShelf";
        ice.transform.SetParent(cove.transform, false);
        ice.transform.localScale = new Vector3(140f, 0.2f, 140f);
        ice.transform.position = new Vector3(0f, 0.2f, 0f);
        var iceMat = FabMat("FabIce", new Color(0.86f, 0.92f, 0.97f), 0.35f);
        iceMat.SetFloat("_Smoothness", 0.55f);
        ice.GetComponent<MeshRenderer>().sharedMaterial = iceMat;
        ice.isStatic = true;

        // Декоративные торосы по кругу (утёсы VertexRage, перекрашены в лёд-тон)
        ScatterPrefab(cove.transform, "Assets/Fab/VertexRageStudio/LowPolyNature/Prefabs/Env/Cliffs/CliffA.prefab", 10, 95f, 108f, 0f, 0.3f, 1.6f, iceTint: true);
        ScatterPrefab(cove.transform, "Assets/Fab/VertexRageStudio/LowPolyNature/Prefabs/Env/Cliffs/CliffC.prefab", 8, 90f, 104f, 20f, 0.4f, 2.0f, iceTint: true);
        ScatterPrefab(cove.transform, "Assets/Fab/VertexRageStudio/LowPolyNature/Prefabs/Env/Rocks/RockBlueA.prefab", 12, 60f, 85f, -0.1f, 0.5f, 1.4f);

        // Ели-«прибрежные» (низкополигональные, как «полярные» деревья мира Белека)
        ScatterPrefab(cove.transform, "Assets/Fab/VertexRageStudio/LowPolyNature/Prefabs/Env/Trees/Pines/PinesVariantA/PineVariantAAdultA.prefab", 9, 55f, 88f, 0f, 0.8f, 1.5f);
        ScatterPrefab(cove.transform, "Assets/Fab/VertexRageStudio/LowPolyNature/Prefabs/Env/Trees/Pines/PinesVariantB/PineVariantBAdultA.prefab", 7, 55f, 85f, 140f, 0.8f, 1.4f);

        // Маяк Деда Прибоя (центр хаба)
        BuildLighthouse(cove.transform);

        // Арки-порталы (кольцо хаба: Открытое Море / Ледяные Сады / «скоро»)
        BuildPortal(cove.transform, new Vector3(-24f, 0.6f, 0f), 0f, RealmId.OpenSea, "Portal_OpenSea", new Color(0.5f, 0.8f, 1f));
        BuildPortal(cove.transform, new Vector3(24f, 0.6f, 0f), 180f, RealmId.IceGardens, "Portal_IceGardens", new Color(0.95f, 0.6f, 0.85f));
        BuildPortal(cove.transform, new Vector3(0f, 0.6f, -24f), 90f, RealmId.WarmCove, "Portal_Locked", new Color(0.5f, 0.5f, 0.55f), locked: true);

        // БИП-7 — робот-зонд Fab (Robot3), друг и гид
        var robot = LoadPrefab("Assets/Fab/Robot3/Prefab/SKM_Robot3_Full.prefab");
        if (robot != null)
        {
            var bip = (GameObject)PrefabUtility.InstantiatePrefab(robot);
            bip.name = "NPC_BIP7";
            bip.transform.SetParent(cove.transform, false);
            bip.transform.position = new Vector3(8f, 0.4f, 8f);
            bip.transform.rotation = Quaternion.Euler(0f, 215f, 0f);
            FixFabRenderers(bip);
            var npc = bip.AddComponent<NpcFriend>();
            npc.Configure("bip7", new[]
            {
                "БИП! Добро пожаловать домой, Белёк!",
                "Данные собраны: жемчуг светится ярче твоей улыбки!",
                "За восточной аркой шумит риф. Проверим?",
                "Маяк стал ярче. Мои сенсоры довольны!",
            });
            // Мягкий коллайдер, чтобы не проваливался
            var bc = bip.GetComponentInChildren<Collider>();
            if (bc == null) { var c = bip.AddComponent<BoxCollider>(); c.center = new Vector3(0f, 1f, 0f); c.size = new Vector3(1.4f, 2f, 1.4f); }
        }

        // Жемчужная дорожка «первый сбор» (старт в хабе — 10 сек до первой награды)
        PearlTrail(cove.transform, new Vector3(-6f, 1.2f, 10f), new Vector3(10f, 1.2f, 18f), 8, 1.0f);

        // Место Марты (в v0.5.0 — торговый камень)
        var marta = GameObject.CreatePrimitive(PrimitiveType.Cube);
        marta.name = "Spot_Marta";
        marta.transform.SetParent(cove.transform, false);
        marta.transform.position = new Vector3(-10f, 0.8f, -12f);
        marta.transform.localScale = new Vector3(2.2f, 1.2f, 1.6f);
        marta.GetComponent<MeshRenderer>().sharedMaterial = FabMat("FabStone", new Color(0.55f, 0.58f, 0.62f), 0.7f);
        marta.isStatic = true;
    }

    // ---------------------------------------------------------- ледяные сады
    private static void BuildIceGardens(Transform parent)
    {
        var garden = new GameObject("Realm_IceGardens");
        garden.transform.SetParent(parent, false);
        garden.transform.position = new Vector3(GardenX, 0f, GardenZ);

        // Песчаное дно рифа (глубина −8: комфортно, продухи рядом)
        var floor = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        floor.name = "ReefFloor";
        floor.transform.SetParent(garden.transform, false);
        floor.transform.localScale = new Vector3(180f, 0.2f, 180f);
        floor.transform.position = new Vector3(0f, -8.2f, 0f);
        floor.GetComponent<MeshRenderer>().sharedMaterial = FabMat("FabSand", new Color(0.87f, 0.8f, 0.66f), 0.85f);
        floor.isStatic = true;

        // Кораллы Fab: три «сада» группами + одиночные
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Groups/Coral1_G1.prefab", 10, 12f, 60f, -8f, 0.8f, 1.8f);
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Groups/Coral2_G1.prefab", 10, 12f, 62f, -8f, 0.8f, 1.7f);
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Groups/Coral3_G1.prefab", 8, 14f, 58f, -8f, 0.7f, 1.6f);
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Coral1_1.prefab", 12, 8f, 66f, -8f, 0.6f, 1.5f);
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Coral5_1.prefab", 12, 8f, 64f, -8f, 0.6f, 1.5f);
        ScatterPrefab(garden.transform, "Assets/Fab/_Corals/Prefabs/Coral9_3.prefab", 10, 9f, 60f, -8f, 0.6f, 1.4f);

        // Жемчужные дорожки (3 петли) — цикл 30 секунд
        PearlTrail(garden.transform, new Vector3(-18f, -5.2f, 6f), new Vector3(-2f, -4.6f, 14f), 10, 1.1f);
        PearlTrail(garden.transform, new Vector3(8f, -5.4f, -10f), new Vector3(26f, -4.8f, -2f), 10, 1.1f);
        PearlTrail(garden.transform, new Vector3(-8f, -6.4f, -20f), new Vector3(6f, -5.8f, -30f), 9, 1.0f);

        // Поющая Раковина (цель реалма, оживёт в v0.5.0)
        var shell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        shell.name = "SingingShell";
        shell.transform.SetParent(garden.transform, false);
        shell.transform.position = new Vector3(0f, -7.6f, 0f);
        shell.transform.localScale = new Vector3(2.4f, 1.6f, 2.4f);
        var shellMat = FabMat("FabShell", new Color(0.98f, 0.9f, 0.82f), 0.15f);
        shellMat.EnableKeyword("_EMISSION");
        shellMat.SetColor("_EmissionColor", new Color(0.35f, 0.55f, 0.6f) * 0.7f);
        shell.GetComponent<MeshRenderer>().sharedMaterial = shellMat;

        // Возвратная арка в хаб (под водой, у входа в сады)
        BuildPortal(garden.transform, new Vector3(0f, -5f, 46f), 0f, RealmId.WarmCove, "Portal_Back_Cove", new Color(0.95f, 0.6f, 0.85f));
    }

    // ---------------------------------------------------- открытое море: возврат
    private static void BuildOpenSeaReturn(Transform parent)
    {
        var sea = new GameObject("Realm_OpenSea_Extras");
        sea.transform.SetParent(parent, false);
        // Возвратная арка у стартовой льдины (видна при выходе в открытую игру)
        BuildPortal(sea.transform, new Vector3(6f, 0.4f, 6f), 0f, RealmId.WarmCove, "Portal_Back_Cove_Sea", new Color(0.95f, 0.6f, 0.85f));
        // Жемчуг-намёк у спавна: «мир отвечает сразу»
        PearlTrail(sea.transform, new Vector3(2f, 0.8f, 2f), new Vector3(9f, 0.8f, 9f), 5, 0.9f);
    }

    // ------------------------------------------------------------- системы мира
    private static void BuildRealmSystems(Transform parent, Transform player)
    {
        var sys = new GameObject("RealmSystems");
        sys.transform.SetParent(parent, false);

        var rm = sys.AddComponent<RealmManager>();
        rm.realms = new[]
        {
            new RealmManager.RealmEntry { id = RealmId.OpenSea,   titleKey = "realm.opensea",   spawnPoint = new Vector3(0f, -1.5f, 0f),      focus = null },
            new RealmManager.RealmEntry { id = RealmId.WarmCove,  titleKey = "realm.warmcove",  spawnPoint = new Vector3(CoveX, 0.6f, CoveZ + 8f), focus = null },
            new RealmManager.RealmEntry { id = RealmId.IceGardens,titleKey = "realm.icegardens",spawnPoint = new Vector3(GardenX, -4.5f, GardenZ + 34f), focus = null },
        };
        // Игрок стартует в хабе — синхронизируем (иначе первый портал «море» игнорируется)
        rm.SetCurrentSilently(RealmId.WarmCove);

        sys.AddComponent<PearlLedger>();

        // Белёк стартует в Тёплой Бухте (хаб — точка входа Большого Мира)
        if (player != null)
        {
            player.position = new Vector3(CoveX, 0.6f, CoveZ + 8f);
            Debug.Log($"[HubRealmBuilder] Player spawn moved to WarmCove: {player.position}");
        }
    }

    // ------------------------------------------------------------------ утилиты
    private static GameObject LoadPrefab(string path)
    {
        var p = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        if (p == null) Debug.LogWarning($"[HubRealmBuilder] Prefab missing: {path}");
        return p;
    }

    private static void FixFabRenderers(GameObject root)
    {
        foreach (var r in root.GetComponentsInChildren<Renderer>(true))
        {
            foreach (var m in r.sharedMaterials)
            {
                if (m == null) continue;
                m.enableInstancing = true;
                var sn = m.shader != null ? m.shader.name : "";
                if (sn == "Standard" || sn.StartsWith("Legacy") || sn.StartsWith("Autodesk"))
                {
                    var lit = Shader.Find("Universal Render Pipeline/Lit");
                    if (lit != null)
                    {
                        var mainTex = m.HasProperty("_MainTex") ? m.GetTexture("_MainTex") : null;
                        var col = m.HasProperty("_Color") ? m.GetColor("_Color") : Color.white;
                        m.shader = lit;
                        if (m.HasProperty("_BaseMap")) m.SetTexture("_BaseMap", mainTex);
                        if (m.HasProperty("_BaseColor")) m.SetColor("_BaseColor", col);
                    }
                }
            }
        }
    }

    private static void ScatterPrefab(Transform parent, string path, int count,
        float rMin, float rMax, float y, float sMin, float sMax, bool iceTint = false)
    {
        var prefab = LoadPrefab(path);
        if (prefab == null) return;
        var holderName = "Scatter_" + prefab.name;
        var holder = new GameObject(holderName);
        holder.transform.SetParent(parent, false);

        for (int i = 0; i < count; i++)
        {
            double a = _rng.NextDouble() * System.Math.PI * 2;
            double r = rMin + _rng.NextDouble() * (rMax - rMin);
            float s = sMin + (float)_rng.NextDouble() * (sMax - sMin);
            var go = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
            go.transform.SetParent(holder.transform, false);
            go.transform.localPosition = new Vector3((float)(System.Math.Cos(a) * r), y, (float)(System.Math.Sin(a) * r));
            go.transform.rotation = Quaternion.Euler(0f, (float)(_rng.NextDouble() * 360), 0f);
            go.transform.localScale = Vector3.one * s;
            if (iceTint) TintToIce(go);
            FixFabRenderers(go);
        }
        holder.isStatic = true;
    }

    private static void TintToIce(GameObject root)
    {
        foreach (var r in root.GetComponentsInChildren<Renderer>(true))
        {
            foreach (var m in r.sharedMaterials)
            {
                if (m == null) continue;
                // Лёгкий обесцвечивающий тон арктики (сохраняет текстуру)
                var cKey = m.HasProperty("_BaseColor") ? "_BaseColor" : (m.HasProperty("_Color") ? "_Color" : null);
                if (cKey == null) continue;
                var c = m.GetColor(cKey);
                m.SetColor(cKey, Color.Lerp(c, new Color(0.82f, 0.90f, 0.96f, c.a), 0.55f));
            }
        }
    }

    private static void BuildLighthouse(Transform cove)
    {
        var lh = new GameObject("Lighthouse");
        lh.transform.SetParent(cove.transform, false);
        lh.transform.localPosition = new Vector3(0f, 0.4f, 0f);

        var mat = FabMat("FabLighthouse", new Color(0.93f, 0.94f, 0.96f), 0.5f);
        var stripe = FabMat("FabLighthouseStripe", new Color(0.85f, 0.35f, 0.3f), 0.5f);

        MakeTower(lh, mat, 0f, 9f, 1.5f);
        MakeTower(lh, stripe, 3f, 1.6f, 1.42f);
        MakeTower(lh, stripe, 6f, 1.6f, 1.34f);

        var cap = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cap.name = "Cap";
        cap.transform.SetParent(lh.transform, false);
        cap.transform.localPosition = new Vector3(0f, 9.6f, 0f);
        cap.transform.localScale = new Vector3(2.6f, 0.35f, 2.6f);
        cap.GetComponent<MeshRenderer>().sharedMaterial = mat;
        cap.isStatic = true;

        var lampGo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        lampGo.name = "Lamp";
        lampGo.transform.SetParent(lh.transform, false);
        lampGo.transform.localPosition = new Vector3(0f, 9.1f, 0f);
        lampGo.transform.localScale = Vector3.one * 1.1f;
        var lampMat = FabMat("FabLamp", new Color(1f, 0.88f, 0.6f), 0f);
        lampMat.EnableKeyword("_EMISSION");
        lampMat.SetColor("_EmissionColor", new Color(1f, 0.82f, 0.45f) * 2.2f);
        lampGo.GetComponent<MeshRenderer>().sharedMaterial = lampMat;

        var light = lampGo.AddComponent<Light>();
        light.type = LightType.Point;
        light.color = new Color(1f, 0.85f, 0.55f);
        light.intensity = 1.5f;
        light.range = 45f;

        var glow = lh.AddComponent<LighthouseGlow>();
        SetPrivate(glow, "lampRenderer", lampGo.GetComponent<MeshRenderer>());
        SetPrivate(glow, "lampLight", light);
    }

    private static void MakeTower(GameObject lh, Material mat, float y, float h, float radius)
    {
        var t = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        t.name = "Tower_" + y;
        t.transform.SetParent(lh.transform, false);
        t.transform.localPosition = new Vector3(0f, y + h / 2f, 0f);
        t.transform.localScale = new Vector3(radius * 2f, h / 2f, radius * 2f);
        t.GetComponent<MeshRenderer>().sharedMaterial = mat;
        t.isStatic = true;
    }

    private static void BuildPortal(Transform parent, Vector3 localPos, float yawDeg,
        RealmId dest, string name, Color tint, bool locked = false)
    {
        var portal = new GameObject(name);
        portal.transform.SetParent(parent, false);
        portal.transform.localPosition = localPos;
        portal.transform.localRotation = Quaternion.Euler(0f, yawDeg, 0f);

        var mat = FabMat("Portal_" + name, tint, 0.1f);
        mat.EnableKeyword("_EMISSION");
        mat.SetColor("_EmissionColor", tint * (locked ? 0.25f : 1.4f));

        // Арка: два столба + перекладина (читаемая «дверь» для 5 лет)
        MakePortalPillar(portal.transform, mat, new Vector3(-2.2f, 1.6f, 0f), 3.2f);
        MakePortalPillar(portal.transform, mat, new Vector3(2.2f, 1.6f, 0f), 3.2f);
        var top = GameObject.CreatePrimitive(PrimitiveType.Cube);
        top.name = "Top";
        top.transform.SetParent(portal.transform, false);
        top.transform.localPosition = new Vector3(0f, 3.4f, 0f);
        top.transform.localScale = new Vector3(5.6f, 0.8f, 1.1f);
        top.GetComponent<MeshRenderer>().sharedMaterial = mat;
        top.isStatic = true;

        if (locked) return; // «скоро»: без триггера, но видно и светится слабо

        var trig = portal.AddComponent<BoxCollider>();
        trig.isTrigger = true;
        trig.center = new Vector3(0f, 1.8f, 0f);
        trig.size = new Vector3(3.4f, 3.6f, 1.6f);

        var rp = portal.AddComponent<RealmPortal>();
        SetPrivate(rp, "destination", dest);
    }

    private static void MakePortalPillar(Transform portal, Material mat, Vector3 pos, float h)
    {
        var p = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p.name = "Pillar";
        p.transform.SetParent(portal, false);
        p.transform.localPosition = pos;
        p.transform.localScale = new Vector3(1.1f, h, 1.1f);
        p.GetComponent<MeshRenderer>().sharedMaterial = mat;
        p.isStatic = true;
    }

    private static void PearlTrail(Transform parent, Vector3 from, Vector3 to, int count, float yStep)
    {
        var holder = new GameObject("PearlTrail_" + from.x.ToString("0"));
        holder.transform.SetParent(parent, false);
        var pearlMat = FabMat("FabPearl", new Color(1f, 0.97f, 0.88f), 0.05f);
        pearlMat.EnableKeyword("_EMISSION");
        pearlMat.SetColor("_EmissionColor", new Color(1f, 0.9f, 0.6f) * 0.9f);

        for (int i = 0; i < count; i++)
        {
            float t = count == 1 ? 0 : (float)i / (count - 1);
            var pos = Vector3.Lerp(from, to, t);
            // лёгкая дуга (синус) — ребёнок видит «дорожку» и ведёт по ней
            pos.y += Mathf.Sin(t * Mathf.PI) * yStep * 2.2f;

            var pearl = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            pearl.name = "Pearl_" + i;
            pearl.transform.SetParent(holder.transform, false);
            pearl.transform.localPosition = pos;
            pearl.transform.localScale = Vector3.one * 0.55f;
            pearl.GetComponent<MeshRenderer>().sharedMaterial = pearlMat;
            pearl.AddComponent<PearlPickup>();
        }
    }

    private static Material FabMat(string name, Color color, float smooth)
    {
        var m = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        m.name = name;
        m.color = color;
        m.SetFloat("_Smoothness", smooth);
        m.enableInstancing = true;
        return m;
    }

    private static void SetPrivate(object o, string field, object value)
    {
        var f = o.GetType().GetField(field,
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        f?.SetValue(o, value);
    }
}
