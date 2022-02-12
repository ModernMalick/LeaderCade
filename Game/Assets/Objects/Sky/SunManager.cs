using System;
using System.Collections;
using System.Collections.Generic;
using Objects.Ball;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    private void Update()
    {
        gameObject.transform.Rotate(0.01f, 0f, 0f);
    }
}
