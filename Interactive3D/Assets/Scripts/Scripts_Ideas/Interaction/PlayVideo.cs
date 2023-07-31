using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : InteractableObject
{
    // Reference to the audio source
    public VideoPlayer videoSource;

    // Clip to play
    public VideoClip videoClip;
    
    void Start()
    {
        videoSource.clip = videoClip;
        videoSource.playOnAwake = false;
    }

    public override void TriggerInteraction() 
    {
        if(videoSource.isPlaying) 
        {
            videoSource.Pause();
        }
        else
        {
            videoSource.Play();
        }
    }

}
