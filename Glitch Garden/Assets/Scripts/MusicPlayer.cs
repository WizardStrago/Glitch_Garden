using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    public static GameObject backgroundMusicObject;

    void Start()
    {
        // the background music will not be called again once created.
        if (backgroundMusicObject)
        {
            Destroy(gameObject);
            return;
        }

        // the background music should continue without interruption
        DontDestroyOnLoad(this);
        backgroundMusicObject = gameObject;

        // code for volume management
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
