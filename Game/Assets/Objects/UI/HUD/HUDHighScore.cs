using Objects.Ball;
using TMPro;
using UnityEngine;

namespace Objects.UI.HUD
{
    public class HUDHighScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = ScoreManager.Instance.HighScore.ToString("0");
            BallCollisionManager.OnScoring += UpdateHighScore;
        }

        private void OnDestroy()
        {
            BallCollisionManager.OnScoring -= UpdateHighScore;
        }

        private void UpdateHighScore()
        {
            if (ScoreManager.Instance.Score < ScoreManager.Instance.PrefsHighScore) return;
            _textMeshPro.text = ScoreManager.Instance.HighScore.ToString("0");
        }
    }
}