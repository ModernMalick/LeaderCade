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
        }

        private void Update()
        {
            _textMeshPro.text = ScoreManager.Instance.HighScore.ToString("0");
        }
    }
}
