using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSchubladegross : InteractableObject
{
    public Animator Gross;

    private bool currentSchubladegrossState;

    public override void TriggerInteraction()
    {
        currentSchubladegrossState = Gross.GetBool("isOpen");
        Gross.SetBool("isOpen", !currentSchubladegrossState);

        if (!currentSchubladegrossState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
