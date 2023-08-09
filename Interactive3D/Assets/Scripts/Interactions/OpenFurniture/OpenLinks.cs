using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinks : InteractableObject
{
    public Animator Links;

    private bool currentBalkontuerLinksState;

    public override void TriggerInteraction()
    {
        currentBalkontuerLinksState = Links.GetBool("isOpen");
        Links.SetBool("isOpen", !currentBalkontuerLinksState);

        if (!currentBalkontuerLinksState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
