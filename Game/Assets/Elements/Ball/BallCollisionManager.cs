using UnityEngine;

namespace Elements.Ball
{
    public class BallCollisionManager : MonoBehaviour
    {
        [HideInInspector] public bool scored;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Target"))
            {
                scored = true;
            }
            else if (collision.collider.CompareTag("Obstacle"))
            {
                Debug.Log("DEAD");
            }
        }
    }
}
