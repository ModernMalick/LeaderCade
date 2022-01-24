using UnityEngine;

namespace Objects.UI.Menu
{
    public class Navigation : MonoBehaviour
    {
        [SerializeField] private GameObject panelMain;
        [SerializeField] private GameObject panelTeams;
        [SerializeField] private GameObject panelTeamCreation;

        public void OnClickTeams()
        {
            panelMain.SetActive(false);
            panelTeams.SetActive(true);
        }

        public void OnClickTeamCreation()
        {
            panelTeams.SetActive(false);
            panelTeamCreation.SetActive(true);
        }
    }
}