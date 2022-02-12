using TMPro;
using UnityEngine;

namespace Objects.UI.Loss
{
    public class LossHighScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = "Highscore : " + ScoreManager.Instance.HighScore.ToString("0");
        }
    }
}
