using TMPro;
using UnityEngine;

namespace Objects.UI.HUD
{
    public class HUDTime : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
        }

        private void Update()
        {
            _textMeshPro.text = TimeManager.Instance.RemainingTime.ToString("0");
        }
    }
}
