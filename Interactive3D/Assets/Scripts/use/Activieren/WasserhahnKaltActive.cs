using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasserhahnKaltActive : InteractableObject
{
    public GameObject Wassertropfen;

    private bool currentWasserhahnState;

    public override void TriggerInteraction()
    {
        currentWasserhahnState = Wassertropfen.activeSelf;
        Wassertropfen.SetActive(!currentWasserhahnState);

        if (!currentWasserhahnState)
        {
            commandText = "Kalt Aus";
        }
        else 
        {
            commandText = "Kalt An";
        }
    }
}
