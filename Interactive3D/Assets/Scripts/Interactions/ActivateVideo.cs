using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ActivateVideo : InteractableObject
{
    public VideoPlayer videoSource;
    public VideoClip videoClip;

    // Start is called before the first frame update
    void Start()
    {
        videoSource.clip = videoClip;
        videoSource.playOnAwake = false;
    }

    // Update is called once per frame
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
