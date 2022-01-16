using Elements.Ball;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")] [SerializeField] private Text text;

    [Header("VARIABLES")] [SerializeField] private int startIncrement;

    [SerializeField] private int incrementPercentage;

    [HideInInspector] public int score;
    private int _scoreIncrements;

    private void Start()
    {
        score = 0;
        _scoreIncrements = startIncrement;
        BallCollisionManager.OnScoring += Scorer;
    }

    private void Update()
    {
        text.text = score.ToString();
    }

    private void Scorer()
    {
        score += _scoreIncrements;
        _scoreIncrements += _scoreIncrements / 100 * incrementPercentage;
    }
}