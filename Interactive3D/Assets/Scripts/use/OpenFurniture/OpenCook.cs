using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCook : InteractableObject
{
    public Animator Cook;

    private bool currentCookState;

    public override void TriggerInteraction()
    {
        currentCookState = Cook.GetBool("isOpen");
        Cook.SetBool("isOpen", !currentCookState);

        if (!currentCookState)
        {
            commandText = "Kochen Aus";
        }
        else 
        {
            commandText = "Kochen";
        }
    }
}
