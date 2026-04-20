using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Volume))]
public class WeatherVisuals : MonoBehaviour
{
    public ParticleSystem rainPS, snowPS, windPS;
    private WeatherSystem weather;
    private Volume volume;
    private DepthOfField dof;
    private Vignette vignette;

    void Start() {
        weather = FindObjectOfType<WeatherSystem>();
        volume = GetComponent<Volume>();
        volume.profile.TryGet(out dof);
        volume.profile.TryGet(out vignette);
        
        weather.OnStateChanged.AddListener(UpdateFX);
    }

    void UpdateFX(WeatherSystem.State state) {
        float vis = weather.Visibility;
        vignette.intensity.value = Mathf.Lerp(0.1f, 0.6f, 1f - (vis / 100f));
        dof.active = state == WeatherSystem.State.Storm || state == WeatherSystem.State.Blizzard;
        
        rainPS.gameObject.SetActive(state == WeatherSystem.State.Storm);
        snowPS.gameObject.SetActive(state == WeatherSystem.State.Blizzard);
        windPS.gameObject.SetActive(weather.IsStorming);
    }
}
