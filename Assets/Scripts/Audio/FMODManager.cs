using UnityEngine;

public class FMODManager : MonoBehaviour
{
    public static FMODManager Instance { get; private set; }
    
    public string ambientEvent;
    public string predatorEvent;
    public string evolutionEvent;

    public string paramDanger = "DangerLevel";
    public string paramDepth = "WaterDepth";
    public string paramStage = "EvolutionStage";

    void Awake() {
        Instance = this;
        Debug.Log("[FMOD] Manager initialized (mock mode)");
    }

    void Update() {
        if (transform != null) {
            float depth = Mathf.Clamp01(-transform.position.y / 50f);
            Debug.Log($"[FMOD] Depth param: {depth}");
        }
    }

    public void TriggerPredatorEncounter() {
        Debug.Log("[FMOD] Triggering predator encounter");
    }
    
    public void TriggerEvolution() {
        Debug.Log("[FMOD] Triggering evolution");
    }
}
