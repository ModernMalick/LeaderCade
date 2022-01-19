using Objects.Ball;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [field: HideInInspector]
    public int Score { get; private set; }
    public int HighScore { get; private set; }
    public  int PrefsHighScore { get; private set; }

    public static ScoreManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        PrefsHighScore = PlayerPrefs.GetInt("highscore", 0);
        HighScore = PrefsHighScore;
    }

    private void Start()
    {
        BallCollisionManager.OnScoring += Scorer;
    }

    private void Scorer()
    {
        Score++;
        if (Score < PrefsHighScore) return;
        HighScore = Score;
    }
}