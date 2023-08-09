using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : InteractableObject
{
    public VideoPlayer videoSource;

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
