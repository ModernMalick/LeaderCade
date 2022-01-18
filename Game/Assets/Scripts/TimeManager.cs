using Objects.Ball;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [Header("VARIABLES")] [SerializeField] private float timeIncrements;

    public static TimeManager Instance { get; private set; }

    public float RemainingTime { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        RemainingTime = timeIncrements;
        BallCollisionManager.OnScoring += () => RemainingTime = timeIncrements;
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