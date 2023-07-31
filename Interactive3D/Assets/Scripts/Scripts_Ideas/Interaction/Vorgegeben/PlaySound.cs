using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : InteractableObject
{
    // Reference to the audio source
    public AudioSource audioSource;

    // Clip to play
    public AudioClip audioClip;
    
    void Start()
    {
        audioSource.clip = audioClip;
        audioSource.playOnAwake = false;
    }

    public override void TriggerInteraction() 
    {
        if(audioSource.isPlaying) 
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }

}
