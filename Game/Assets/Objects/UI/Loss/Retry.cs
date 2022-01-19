using UnityEngine;
using UnityEngine.SceneManagement;

namespace Objects.UI.Loss
{
    public class Retry : MonoBehaviour
    {
        public void OnRetry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}