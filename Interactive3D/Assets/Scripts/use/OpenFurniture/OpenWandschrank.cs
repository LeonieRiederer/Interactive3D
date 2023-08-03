using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWandschrank : InteractableObject
{
    public Animator Wandschrank;

    private bool currentWandschrankState;

    public override void TriggerInteraction()
    {
        currentWandschrankState = Wandschrank.GetBool("isOpen");
        Wandschrank.SetBool("isOpen", !currentWandschrankState);

        if (!currentWandschrankState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
