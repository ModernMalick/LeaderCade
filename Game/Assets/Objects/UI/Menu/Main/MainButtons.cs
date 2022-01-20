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
    }
}