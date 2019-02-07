using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public SoundCollection sounds;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(int soundNumber)
    {
        audioSource.clip = sounds.sounds[soundNumber];
        audioSource.Play();
    }

}
