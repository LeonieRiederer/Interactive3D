using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSchrankKlappe : InteractableObject
{
    public Animator SchrankKlappe;

    private bool currentSchrankKlappeState;

    public override void TriggerInteraction()
    {
        currentSchrankKlappeState = SchrankKlappe.GetBool("isOpen");
        SchrankKlappe.SetBool("isOpen", !currentSchrankKlappeState);

        if (!currentSchrankKlappeState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
