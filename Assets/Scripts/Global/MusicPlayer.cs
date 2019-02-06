using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    public MusicCollection musicCollection;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(MusicCollectionEnum chosenMusic)
    {
        audioSource.clip = musicCollection.music[0];
        audioSource.Play();
    }
}
