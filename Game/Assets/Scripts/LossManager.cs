using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossManager : MonoBehaviour
{
    public static event Action Loss;
    public static bool lost;

    public static void OnLoss()
    {
        Debug.Log("DEAD");
        lost = true;
        Loss?.Invoke();
    }
}
