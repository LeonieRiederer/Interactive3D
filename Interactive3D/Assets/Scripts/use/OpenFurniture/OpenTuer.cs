using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTuer : InteractableObject
{
    public Animator Tuer;

    private bool currentTuerState;

    public override void TriggerInteraction()
    {
        currentTuerState = Tuer.GetBool("isOpen");
        Tuer.SetBool("isOpen", !currentTuerState);

        if (!currentTuerState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
