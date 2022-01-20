using Objects.Ball;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    private void Start()
    {
        BallCollisionManager.OnScoring += Scorer;
    }
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PrefsHighScore = PlayerPrefs.GetInt("highscore", 0);
        HighScore = PrefsHighScore;
        Score = 0;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Scorer()
    {
        Score++;
        IncrementTotal();
        if (Score < PrefsHighScore) return;
        HighScore = Score;
    }

    private static void IncrementTotal()
    {
        const string key = "totalscore";
        var currentTotal = PlayerPrefs.GetInt(key, 0);
        PlayerPrefs.SetInt(key, currentTotal + 1);
    }
}