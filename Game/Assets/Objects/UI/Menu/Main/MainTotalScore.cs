using TMPro;
using UnityEngine;

namespace Objects.UI.Menu.Main
{
    public class MainTotalScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = PlayerPrefs.GetInt("totalscore", 0).ToString();
        }
    }
}
