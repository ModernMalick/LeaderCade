using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicManager : MonoBehaviour
{
    void Start()
    {
        var sound = PlayerPrefs.GetInt("Sound");
        if(sound == 1) return;
        gameObject.SetActive(false);
    }
}
