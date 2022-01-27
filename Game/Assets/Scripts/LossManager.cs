using System;
using FireBaseManager;
using Objects.FireBaseManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossManager : MonoBehaviour
{
    private static GameObject _lossPanel;
    public static bool Lost;
    [SerializeField] private GameObject lossPanelPrefab;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public static event Action Loss;

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        CheckPanel();
        _lossPanel.SetActive(false);
        Lost = false;
        Loss += () => { _lossPanel.SetActive(true); };
    }

    public static void OnLoss()
    {
        Lost = true;
        SetHighScore();
        StaticCoroutine.Start(User.UpdateTotalScore());
        Loss?.Invoke();
    }

    private static void SetHighScore()
    {
        var highscore = ScoreManager.Instance.Score;
        if (highscore < PlayerPrefs.GetInt("highscore", 0)) return;
        PlayerPrefs.SetInt("highscore", highscore);
        StaticCoroutine.Start(User.UpdateHighScore());
    }

    private void CheckPanel()
    {
        if (_lossPanel != null) return;
        _lossPanel = Instantiate(lossPanelPrefab);
    }
}