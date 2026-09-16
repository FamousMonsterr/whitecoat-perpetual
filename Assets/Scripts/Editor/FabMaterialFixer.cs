using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Фиксация материалов пакетов Fab под URP (idempotent, вызывается в CI перед
/// каждым билдом — Assets/Fab/**).
///  1) Standard / Legacy / missing shader → Universal Render Pipeline/Lit;
///     перенос _MainTex→_BaseMap, _Color→_BaseColor, _BumpMap→_BumpMap;
///  2) enableInstancing = true на всех материалах Fab (урок v0.3.1: без
///     инстансинга рыбные школы/россыпи пропсов не рисовались);
///  3) TextureImporter: *_N/_Normal → NormalMap (иначе URP рендерит серые
///     нулевые нормали), *_M/_Mask/_ORM → sRGB off.
/// Логи сводные: [FabMaterialFixer] fixed=X, skipped=Y.
/// </summary>
public static class FabMaterialFixer
{
    private const string FabRoot = "Assets/Fab";

    [MenuItem("Whitecoat/Fab/Fix Materials (URP)", priority = 40)]
    public static void FixAllMenu() => FixAll();

    public static void FixAll()
    {
        if (!Directory.Exists(FabRoot)) { Debug.Log("[FabMaterialFixer] No Assets/Fab — skip"); return; }

        var litShader = Shader.Find("Universal Render Pipeline/Lit");
        if (litShader == null) { Debug.LogError("[FabMaterialFixer] URP/Lit not found!"); return; }

        int fixedMats = 0, touchedTextures = 0;
        double t0 = EditorApplication.timeSinceStartup;

        var guids = AssetDatabase.FindAssets("t:Material", new[] { FabRoot });
        foreach (var guid in guids)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var mat = AssetDatabase.LoadAssetAtPath<Material>(path);
            if (mat == null) continue;

            bool dirty = false;
            var shaderName = mat.shader != null ? mat.shader.name : "";

            // Подмена любого не-URP шейдера (Standard/Legacy/кастом Built-in пакета):
            // правила-исключения — совместимые с URP источники.
            bool urpCompat =
                   shaderName.StartsWith("Universal Render Pipeline")
                || shaderName.StartsWith("Shader Graphs")
                || shaderName.StartsWith("Whitecoat/")
                || shaderName.StartsWith("Skybox/")
                || shaderName.StartsWith("UI/")
                || shaderName.StartsWith("Sprites/")
                || shaderName.StartsWith("Text Mesh Pro")
                || shaderName.StartsWith("Hidden/");

            bool needsSwap = string.IsNullOrEmpty(shaderName)
                             || shaderName == "Missing Shader"
                             || !urpCompat;

            if (needsSwap)
            {
                // Перенос свойств до подмены шейдера
                var mainTex = mat.HasProperty("_MainTex") ? mat.GetTexture("_MainTex") : null;
                var color = mat.HasProperty("_Color") ? mat.GetColor("_Color") : Color.white;
                var bump = mat.HasProperty("_BumpMap") ? mat.GetTexture("_BumpMap") : null;
                var emis = mat.HasProperty("_EmissionColor") ? mat.GetColor("_EmissionColor") : Color.black;

                mat.shader = litShader;
                if (mat.HasProperty("_BaseMap")) mat.SetTexture("_BaseMap", mainTex);
                if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", color);
                if (mat.HasProperty("_BumpMap")) mat.SetTexture("_BumpMap", bump);
                if (mat.HasProperty("_EmissionColor")) mat.SetColor("_EmissionColor", emis);
                dirty = true;
            }

            if (mat.enableInstancing == false) { mat.enableInstancing = true; dirty = true; }

            if (dirty) { EditorUtility.SetDirty(mat); fixedMats++; }
        }

        // Текстуры: нормал-мапы и маски
        var texGuids = AssetDatabase.FindAssets("t:Texture2D", new[] { FabRoot });
        foreach (var guid in texGuids)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var name = Path.GetFileNameWithoutExtension(path).ToLowerInvariant();
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;
            if (importer == null) continue;

            bool dirty = false;
            bool isNormal = name.EndsWith("_n") || name.Contains("_normal") || name.Contains("normal_") || name.EndsWith("_nrm");
            bool isMask = name.Contains("_mask") || name.Contains("_orm") || name.Contains("_metallic") || name.Contains("_roughness") || name.Contains("_occlusion") || name.Contains("_smoothness");

            if (isNormal && importer.textureType != TextureImporterType.NormalMap)
            {
                importer.textureType = TextureImporterType.NormalMap;
                dirty = true;
            }
            if (isMask && importer.sRGBTexture)
            {
                importer.sRGBTexture = false;
                dirty = true;
            }
            // Производительность: пропсы пакета не больше 2K, мелочь 1K
            if (importer.maxTextureSize > 2048) { importer.maxTextureSize = 2048; dirty = true; }

            if (dirty) { importer.SaveAndReimport(); touchedTextures++; }
        }

        AssetDatabase.SaveAssets();
        Debug.Log($"[FabMaterialFixer] fixed={fixedMats} mats, reimported={touchedTextures} textures in {EditorApplication.timeSinceStartup - t0:F1}s");
    }
}
