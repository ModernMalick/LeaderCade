using Elements.Ball;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("UI")] [SerializeField] private Text text;

    [Header("VARIABLES")] [SerializeField] private float timeIncrements;

    private float _remainingTime;

    private void Start()
    {
        _remainingTime = timeIncrements;
        BallCollisionManager.OnScoring += AddTime;
    }

    private void Update()
    {
        if (_remainingTime <= 0)
        {
            LossManager.OnLoss();
            return;
        }

        _remainingTime -= Time.deltaTime;
        text.text = _remainingTime.ToString("F0");
    }

    private void AddTime()
    {
        _remainingTime = timeIncrements;
    }
}