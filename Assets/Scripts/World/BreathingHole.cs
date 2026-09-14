using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Прорубь (лунка во льду): безопасное место дыхания и убежище от касатки.
/// </summary>
public class BreathingHole : MonoBehaviour
{
    public static readonly List<BreathingHole> Active = new List<BreathingHole>();

    public float radius = 1.6f;

    private void OnEnable() { Active.Add(this); }
    private void OnDisable() { Active.Remove(this); }

    public static bool IsInAnyHole(Vector3 pos)
    {
        for (int i = 0; i < Active.Count; i++)
        {
            var h = Active[i];
            if (h == null) continue;
            Vector2 d = new Vector2(pos.x - h.transform.position.x, pos.z - h.transform.position.z);
            if (d.sqrMagnitude < h.radius * h.radius) return true;
        }
        return false;
    }

    public static BreathingHole Nearest(Vector3 pos, float maxDist = 40f)
    {
        BreathingHole best = null;
        float bestSqr = maxDist * maxDist;
        for (int i = 0; i < Active.Count; i++)
        {
            var h = Active[i];
            if (h == null) continue;
            Vector2 d = new Vector2(pos.x - h.transform.position.x, pos.z - h.transform.position.z);
            float sqr = d.sqrMagnitude;
            if (sqr < bestSqr) { bestSqr = sqr; best = h; }
        }
        return best;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0.2f, 0.8f, 1f, 0.5f);
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
