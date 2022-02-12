using System.Collections;
using System.Collections.Generic;
using Objects.Ball;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EffectsManager : MonoBehaviour
{
    [SerializeField] private AudioSource scoring;
    [SerializeField] private AudioSource loss;
    
    private void OnEnable()
    {
        BallCollisionManager.OnScoring += PlayScore;
        LossManager.Loss += PlayLoss;
    }

    private void OnDisable()
    {
        BallCollisionManager.OnScoring -= PlayScore;
        LossManager.Loss -= PlayLoss;
    }

    private void PlayScore()
    {
        scoring.Play();
    }
    
    private void PlayLoss()
    {
        loss.Play();
    }
}
