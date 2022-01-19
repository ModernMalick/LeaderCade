using System;
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
        Loss?.Invoke();
    }

    private static void SetHighScore()
    {
        if (ScoreManager.Instance.Score < PlayerPrefs.GetInt("highscore", 0)) return;
        PlayerPrefs.SetInt("highscore", ScoreManager.Instance.Score);
    }

    private void CheckPanel()
    {
        if(_lossPanel != null) return;
        _lossPanel = Instantiate(lossPanelPrefab);
    }
}