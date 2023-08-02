using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserhahnWarmActive : InteractableObject
{
    public GameObject WassertropfenWarm;

    private bool currentWasserhahnState;

    public override void TriggerInteraction()
    {
        currentWasserhahnState = WassertropfenWarm.activeSelf;
        WassertropfenWarm.SetActive(!currentWasserhahnState);

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
