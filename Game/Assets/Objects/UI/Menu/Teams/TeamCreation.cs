using Objects.FireBaseManager;
using TMPro;
using UnityEngine;

namespace Objects.UI.Menu.Teams
{
    public class TeamCreation : MonoBehaviour
    {
        [SerializeField] private GameObject nameInput;

        public void CreateTeam()
        {
            var input = nameInput.GetComponent<TextMeshProUGUI>();
            if (string.IsNullOrEmpty(input.text)) return;
            var inputText = input.text;
            FirebaseManager.CreateTeam(inputText);
        }
    }
}