using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

/// <summary>
/// Создание URP-материалов из сгенерированных текстур (Blender → Unity).
/// </summary>
public static class MaterialBuilder
{
    private const string TexDir = "Assets/Art/Textures";
    private const string OutDir = "Assets/Art/Materials";

    public static Material Build(string name, string texName, float roughness, string normalTex = null,
        float metallic = 0f, bool transparent = false, Color? baseTint = null, string smoothTex = null)
    {
        Directory.CreateDirectory(OutDir);
        var path = $"{OutDir}/{name}.mat";
        var existing = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (existing != null) return existing;

        var mat = new Material(Shader.Find("Universal Render Pipeline/Lit"));

        var albedo = LoadTex(texName);
        if (albedo != null) mat.SetTexture("_BaseMap", albedo);
        if (baseTint.HasValue) mat.SetColor("_BaseColor", baseTint.Value);
        mat.SetFloat("_Smoothness", 1f - roughness);
        mat.SetFloat("_Metallic", metallic);

        // Карта гладкости (блики): R=metallic(0), A=smoothness — линейное пространство
        if (!string.IsNullOrEmpty(smoothTex))
        {
            var sm = LoadTex(smoothTex);
            if (sm != null)
            {
                MarkLinearMap(sm);
                mat.SetTexture("_MetallicSpecGlossMap", sm);
                mat.EnableKeyword("_METALLICSPECGLOSSMAP");
                mat.SetFloat("_Smoothness", 1f); // масштаб — сама карта кодирует гладкость
                mat.SetFloat("_Metallic", 0f);
            }
        }

        if (!string.IsNullOrEmpty(normalTex))
        {
            var n = LoadTex(normalTex);
            if (n != null)
            {
                MarkNormalMap(n);
                mat.SetTexture("_BumpMap", n);
                mat.EnableKeyword("_NORMALMAP");
                mat.SetFloat("_BumpScale", 0.7f);
            }
        }

        if (transparent)
        {
            mat.SetFloat("_Surface", 1f); // Transparent
            mat.SetFloat("_Blend", 0f);   // Alpha
            mat.SetInt("_SrcBlend", (int)BlendMode.SrcAlpha);
            mat.SetInt("_DstBlend", (int)BlendMode.OneMinusSrcAlpha);
            mat.SetInt("_ZWrite", 0);
            mat.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");
            mat.renderQueue = (int)RenderQueue.Transparent;
            mat.SetOverrideTag("RenderType", "Transparent");
        }

        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }

    private static Texture2D LoadTex(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;
        if (!name.EndsWith(".png") && !name.EndsWith(".jpg")) name += ".png";
        return AssetDatabase.LoadAssetAtPath<Texture2D>($"{TexDir}/{name}");
    }

    private static void MarkNormalMap(Texture2D tex)
    {
        var importer = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(tex)) as TextureImporter;
        if (importer != null && importer.textureType != TextureImporterType.NormalMap)
        {
            importer.textureType = TextureImporterType.NormalMap;
            importer.mipmapEnabled = true;
            importer.SaveAndReimport();
        }
    }

    private static void MarkLinearMap(Texture2D tex)
    {
        var importer = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(tex)) as TextureImporter;
        if (importer != null && importer.sRGBTexture)
        {
            importer.sRGBTexture = false; // данные гладкости — линейные
            importer.mipmapEnabled = true;
            importer.SaveAndReimport();
        }
    }

    public static Material BuildWater()
    {
        Directory.CreateDirectory(OutDir);
        var path = $"{OutDir}/water.mat";
        var existing = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (existing != null) return existing;
        var shader = Shader.Find("Whitecoat/OceanWater");
        if (shader == null) { Debug.LogError("[Materials] OceanWater shader missing"); return null; }
        var mat = new Material(shader);
        mat.SetColor("_ShallowColor", new Color(0.13f, 0.45f, 0.55f));
        mat.SetColor("_DeepColor", new Color(0.02f, 0.10f, 0.20f));
        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }

    public static Material BuildSky()
    {
        Directory.CreateDirectory(OutDir);
        var path = $"{OutDir}/sky.mat";
        var existing = AssetDatabase.LoadAssetAtPath<Material>(path);
        if (existing != null) return existing;
        var shader = Shader.Find("Whitecoat/ArcticSky");
        if (shader == null) { Debug.LogError("[Materials] ArcticSky shader missing"); return null; }
        var mat = new Material(shader);
        AssetDatabase.CreateAsset(mat, path);
        return mat;
    }
}
