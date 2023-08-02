using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : InteractableObject
{
    public GameObject Bett;

    private bool currentBettState;

    public override void TriggerInteraction()
    {
        currentBettState = Bett.activeSelf;
        Bett.SetActive(!currentBettState);

        if (!currentBettState)
        {
            commandText = "Bett 1";
        }
        else 
        {
            commandText = "Bett 2";
        }
    }
}
