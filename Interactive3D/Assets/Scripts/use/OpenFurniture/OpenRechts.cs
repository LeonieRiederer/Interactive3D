using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRechts : InteractableObject
{
    public Animator Rechts;

    private bool currentBalkontuerRechtsState;

    public override void TriggerInteraction()
    {
        currentBalkontuerRechtsState = Rechts.GetBool("isOpen");
        Rechts.SetBool("isOpen", !currentBalkontuerRechtsState);

        if (!currentBalkontuerRechtsState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
