using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource music;

    private bool _soundOn;

    private void Start()
    {
        _soundOn = true;
        PlayerPrefs.SetInt("Sound", 1);
    }

    public void ToggleSound()
    {
        _soundOn = !_soundOn;
        if (_soundOn)
        {
            music.Play();
            PlayerPrefs.SetInt("Sound", 1);
        }
        else
        {
            music.Stop();
            PlayerPrefs.SetInt("Sound", 0);
        }
    }
}
