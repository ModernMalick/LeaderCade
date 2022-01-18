using Objects.Ball;
using TMPro;
using UnityEngine;

namespace Objects.UI.HUD
{
    public class HUDScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = ScoreManager.Instance.Score.ToString("0");
            BallCollisionManager.OnScoring += UpdateScore;
        }

        private void UpdateScore()
        {
            var newScore = ScoreManager.Instance.Score + 1;
            _textMeshPro.text = newScore.ToString("0");
        }
    }
}
