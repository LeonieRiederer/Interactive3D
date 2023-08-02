using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserhahnWarmActive : InteractableObject
{
    public GameObject [] WassertropfenWarm;

    private bool currentWasserhahnState;

    public override void TriggerInteraction()
    {
        currentWasserhahnState = WassertropfenWarm[0].activeSelf;
        for (int i = 0; i<WassertropfenWarm.Length; i++){
            WassertropfenWarm[i].SetActive(!currentWasserhahnState);
        }


        if (!currentWasserhahnState)
        {
            commandText = "Warm Aus";
        }
        else 
        {
            commandText = "Warm An";
        }
    }
}
