using System;
using Objects.FireBaseManager;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Objects.UI.Menu.Main
{
    public class MainTotalScore : MonoBehaviour
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
            _textMeshPro.text = PlayerPrefs.GetInt("totalscore", 0).ToString();
        }
    }
}
