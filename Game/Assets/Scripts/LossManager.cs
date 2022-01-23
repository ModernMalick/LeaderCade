using System;
using Objects.FireBaseManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossManager : MonoBehaviour
{
    public static event Action Loss;
    [SerializeField] private GameObject lossPanelPrefab;
    private static GameObject _lossPanel;
    public static bool Lost;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CheckPanel();
        _lossPanel.SetActive(false);
        Lost = false;
        Loss += () => { _lossPanel.SetActive(true); };
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public static void OnLoss()
    {
        Lost = true;
        SetHighScore();
        FirebaseManager.UpdateTotalScore();
        Loss?.Invoke();
    }

    private static void SetHighScore()
    {
        var highscore = ScoreManager.Instance.Score;
        if (highscore < PlayerPrefs.GetInt("highscore", 0)) return;
        PlayerPrefs.SetInt("highscore", highscore);
        FirebaseManager.UpdateHighScore(highscore);
    }

    private void CheckPanel()
    {
        if(_lossPanel != null) return;
        _lossPanel = Instantiate(lossPanelPrefab);
    }
}