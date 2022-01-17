using Elements.Ball;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")] [SerializeField] private Text text;
    [HideInInspector] public int score;

    private void Start()
    {
        score = 0;
        BallCollisionManager.OnScoring += Scorer;
    }

    private void Update()
    {
        text.text = score.ToString();
    }

    private void Scorer()
    {
        score++;
    }
}