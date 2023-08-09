using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSchrank : InteractableObject
{
    public Animator Schrank;

    private bool currentSchrankState;

    public override void TriggerInteraction()
    {
        currentSchrankState = Schrank.GetBool("isOpen");
        Schrank.SetBool("isOpen", !currentSchrankState);

        if (!currentSchrankState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
