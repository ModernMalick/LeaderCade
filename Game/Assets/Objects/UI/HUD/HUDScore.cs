using TMPro;
using UnityEngine;

namespace Objects.UI
{
    public class HUDScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _textMeshPro.text = ScoreManager.Instance.Score.ToString("0");
        }
    }
}
