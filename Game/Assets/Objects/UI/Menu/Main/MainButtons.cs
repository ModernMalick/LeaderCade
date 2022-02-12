using UnityEngine;
using UnityEngine.SceneManagement;

namespace Objects.UI.Menu.Main
{
    public class MainButtons : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene("Gameplay");
        }
        
        public void OpenSite()
        {
            Application.OpenURL("https://malick-ndiaye.github.io/");
        }
    }
}