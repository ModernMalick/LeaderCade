using FireBaseManager;
using Objects.FireBaseManager;
using TMPro;
using UnityEngine;

namespace Objects.UI.Menu.Main
{
    public class MainHighScore : MonoBehaviour
    {
        private TextMeshProUGUI _textMeshPro;

        private void Start()
        {
            SetTexts();
        }

        private void OnEnable()
        {
            FirebaseManager.Load += SetTexts;
        }

        private void OnDisable()
        {
            FirebaseManager.Load -= SetTexts;
        }

        private void SetTexts()
        {
            _textMeshPro = gameObject.GetComponent<TextMeshProUGUI>();
            _textMeshPro.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        }
    }
}