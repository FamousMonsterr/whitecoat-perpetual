using System;
using System.IO;
using UnityEngine;

/// <summary>
/// Сохранения: JSON в persistentDataPath. Работает и в редакторе, и в билде.
/// </summary>
public static class SaveSystem
{
    public static string Dir =>
        Path.Combine(Application.persistentDataPath, "whitecoat");

    public static void WriteFile(string name, string content)
    {
        try
        {
            Directory.CreateDirectory(Dir);
            File.WriteAllText(Path.Combine(Dir, name), content);
        }
        catch (Exception e) { Debug.LogWarning("[Save] write failed: " + e.Message); }
    }

    public static string ReadFile(string name)
    {
        try
        {
            var path = Path.Combine(Dir, name);
            return File.Exists(path) ? File.ReadAllText(path) : null;
        }
        catch (Exception e) { Debug.LogWarning("[Save] read failed: " + e.Message); return null; }
    }

    public static bool HasFile(string name) => File.Exists(Path.Combine(Dir, name));
}
