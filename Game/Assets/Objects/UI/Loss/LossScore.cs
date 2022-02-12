using TMPro;
using UnityEngine;

namespace Objects.UI.Loss
{
    public class LossScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = "Score : " + ScoreManager.Instance.Score.ToString("0");
        }
    }
}
