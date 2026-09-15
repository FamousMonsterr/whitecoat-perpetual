using UnityEngine;

/// <summary>
/// Биолюминесценция: светящийся планктон в толще воды ночью и на глубине.
/// Частицы + 2 point light'а рядом с игроком (бюджет производительности).
/// </summary>
public class Bioluminescence : MonoBehaviour
{
    public ParticleSystem planktonPS;
    public Light glowLightA;
    public Light glowLightB;

    private Transform _seal;
    private DayNightCycle _day;
    private OceanManager _ocean;
    private ParticleSystem.EmissionModule _emission;
    private float _lightSwitch;

    private void Start()
    {
        _day = FindAnyObjectByType<DayNightCycle>();
        _ocean = OceanManager.Instance;
        if (planktonPS != null) _emission = planktonPS.emission;
        if (glowLightA != null) { glowLightA.intensity = 0f; glowLightA.color = new Color(0.2f, 0.9f, 1f); }
        if (glowLightB != null) { glowLightB.intensity = 0f; glowLightB.color = new Color(0.4f, 0.5f, 1f); }
    }

    private void Update()
    {
        if (SealController.Instance == null) return;
        _seal = SealController.Instance.transform;
        Vector3 pos = _seal.position;
        bool under = _ocean != null && _ocean.IsUnderwater(pos);
        float nightFactor = _day != null ? _day.NightFactor : 0f;
        float depthFactor = Mathf.Clamp01(-pos.y / 25f);
        float strength = under ? Mathf.Clamp01(nightFactor * 0.7f + depthFactor * 0.8f) : 0f;

        if (planktonPS != null)
        {
            var main = planktonPS.main;
            main.startColor = new ParticleSystem.MinMaxGradient(
                new Color(0.3f * strength, 0.9f * strength, 1f * strength),
                new Color(0.5f * strength, 0.6f * strength, 1f * strength));
            _emission.rateOverTime = strength * 160f;
            if (strength > 0.05f && !planktonPS.isPlaying) planktonPS.Play();
            if (strength <= 0.05f && planktonPS.isPlaying) planktonPS.Stop();
            planktonPS.transform.position = pos + Vector3.up * 2f;
        }

        // Два мягких огонька, мигают и перемещаются вокруг белька
        _lightSwitch += Time.deltaTime;
        if (glowLightA != null)
        {
            glowLightA.transform.position = pos + new Vector3(
                Mathf.Sin(_lightSwitch * 0.7f) * 4f, 1.5f, Mathf.Cos(_lightSwitch * 0.5f) * 4f);
            glowLightA.intensity = strength * (1.2f + Mathf.Sin(_lightSwitch * 2.1f) * 0.5f);
            glowLightA.range = 9f;
        }
        if (glowLightB != null)
        {
            glowLightB.transform.position = pos + new Vector3(
                Mathf.Sin(_lightSwitch * 0.3f + 2f) * 6f, -1f, Mathf.Cos(_lightSwitch * 0.6f + 1f) * 6f);
            glowLightB.intensity = strength * (0.8f + Mathf.Sin(_lightSwitch * 1.3f + 1f) * 0.4f);
            glowLightB.range = 14f;
        }
    }
}
