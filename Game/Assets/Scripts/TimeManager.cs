using Objects.Ball;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [Header("VARIABLES")] [SerializeField] private float timeIncrements;

    public static TimeManager Instance { get; private set; }

    public float RemainingTime { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        BallCollisionManager.OnScoring += () => RemainingTime = timeIncrements;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RemainingTime = timeIncrements;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Update()
    {
        if(LossManager.Lost) return;

        if (RemainingTime <= 0)
        {
            LossManager.OnLoss();
            return;
        }

        RemainingTime -= Time.deltaTime;
    }
}