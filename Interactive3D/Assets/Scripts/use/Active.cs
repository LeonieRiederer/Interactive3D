using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : InteractableObject
{
    public GameObject [] Bett;

    private int currentBettIndex = 0;

    public override void TriggerInteraction()
    {
        Bett[currentBettIndex].SetActive (false);
        currentBettIndex =(currentBettIndex+1) % Bett.Length;
        Bett[currentBettIndex].SetActive (true);

        if (currentBettIndex==1)
        {
            commandText = "Bett 1";
        }
        else 
        {
            commandText = "Bett 2";
        }
    }
}
