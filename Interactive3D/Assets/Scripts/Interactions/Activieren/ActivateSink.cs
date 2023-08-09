using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSink : InteractableObject
{
    public GameObject [] Sink;

    private int currentSinkIndex = 0;

    public override void TriggerInteraction()
    {
        Sink[currentSinkIndex].SetActive (false);
        currentSinkIndex =(currentSinkIndex+1) % Sink.Length;
        Sink[currentSinkIndex].SetActive (true);

        if (currentSinkIndex==1)
        {
            commandText = "Waschbecken 1";
        }
        else 
        {
            commandText = "Waschbecken 2";
        }
    }
}
