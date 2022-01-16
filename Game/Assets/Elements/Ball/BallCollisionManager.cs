using System;
using UnityEngine;

namespace Elements.Ball
{
    public class BallCollisionManager : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Target"))
                OnScoring?.Invoke();
            else if (collision.collider.CompareTag("Obstacle")) Debug.Log("DEAD");
        }

        public static event Action OnScoring;
    }
}