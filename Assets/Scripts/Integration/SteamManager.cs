using UnityEngine;

public class SteamManager : MonoBehaviour
{
    public static SteamManager Instance { get; private set; }
    public bool Initialized { get; private set; }

    void Awake() {
        Instance = this;
        #if UNITY_STANDALONE_WIN
        Initialized = true;
        Debug.Log("[Steam] Mock Initialized.");
        #else
        Initialized = false;
        #endif
    }

    void Update() {
        if(Initialized) {
            // SteamAPI.RunCallbacks();
        }
    }

    public void UnlockAchievement(string id) {
        if (!Initialized) return;
        Debug.Log($"[Steam] Achievement Unlocked: {id}");
    }
}
