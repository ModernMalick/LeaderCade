using TMPro;
using UnityEngine;

namespace Objects.UI.Menu.Main
{
    public class MainHighScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }
    }
}
