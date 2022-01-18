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
            UpdateScore();
            BallCollisionManager.OnScoring += UpdateScore;
        }

        private void UpdateScore()
        {
            _textMeshPro.text = ScoreManager.Instance.Score.ToString("0");
        }
    }
}
