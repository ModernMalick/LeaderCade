using System;
using UnityEngine;

public class LossManager : MonoBehaviour
{
    public static event Action Loss;

    public static void OnLoss()
    {
        Debug.Log("DEAD");
        Loss?.Invoke();
    }
}