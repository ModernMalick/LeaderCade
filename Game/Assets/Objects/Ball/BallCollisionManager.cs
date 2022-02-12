using System;
using UnityEngine;

namespace Objects.Ball
{
    public class BallCollisionManager : MonoBehaviour
    {
        [SerializeField] private ParticleSystem scoring;
    
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Target"))
            {
                OnScoring?.Invoke();
            }
            else if (collision.collider.CompareTag("Obstacle")) LossManager.OnLoss();
        }

        public static event Action OnScoring;
    }
}