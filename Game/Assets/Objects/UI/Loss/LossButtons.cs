using UnityEngine;
using UnityEngine.SceneManagement;

namespace Objects.UI.Loss
{
    public class LossButtons : MonoBehaviour
    {
        public void Retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}