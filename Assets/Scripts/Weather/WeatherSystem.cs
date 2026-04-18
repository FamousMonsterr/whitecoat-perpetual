using UnityEngine;
using UnityEngine.Events;

public class WeatherSystem : MonoBehaviour
{
    public enum State { Clear, Overcast, Storm, Blizzard }
    public State Current { get; private set; } = State.Clear;
    
    public float Visibility { get; private set; } = 100f;
    public float WaveHeight { get; private set; } = 0.3f;
    public float WindForce { get; private set; } = 0f;
    public bool IsStorming { get; private set; }

    public UnityEvent<State> OnStateChanged;
    private float timer = 0f;
    public float minCycle = 45f, maxCycle = 120f;

    void Update() {
        timer += Time.deltaTime;
        if (timer > Random.Range(minCycle, maxCycle)) {
            timer = 0f;
            Current = (State)Random.Range(0, 4);
            ApplyState(Current);
            OnStateChanged?.Invoke(Current);
        }
    }

    void ApplyState(State s) {
        switch(s) {
            case State.Clear:     SetParams(100f, 0.3f, 0f, false); break;
            case State.Overcast:  SetParams(75f, 0.8f, 3f, false);  break;
            case State.Storm:     SetParams(40f, 2.5f, 8f, true);   break;
            case State.Blizzard:  SetParams(15f, 3.5f, 12f, true);  break;
        }
    }

    void SetParams(float vis, float wave, float wind, bool storm) {
        Visibility = vis; WaveHeight = wave; WindForce = wind; IsStorming = storm;
    }
}
