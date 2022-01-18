using System;
using UnityEngine;

public class LossManager : MonoBehaviour
{
    public static event Action Loss;
    [SerializeField] private GameObject lossPanel;
    public static bool Lost;
    
    private void Start()
    {
        Loss += () => { lossPanel.SetActive(true); };
    }

    public static void OnLoss()
    {
        Lost = true;
        Loss?.Invoke();
    }

    public void Retry()
    {
        Debug.Log("Retry");
    }
}