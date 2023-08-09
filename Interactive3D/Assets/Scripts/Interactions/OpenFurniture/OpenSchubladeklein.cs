using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSchubladeklein : InteractableObject
{
    public Animator Klein;

    private bool currentSchubladekleinState;

    public override void TriggerInteraction()
    {
        currentSchubladekleinState = Klein.GetBool("isOpen");
        Klein.SetBool("isOpen", !currentSchubladekleinState);

        if (!currentSchubladekleinState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
