using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEimer : InteractableObject
{
    public Animator TrashBin;

    private bool currentTrashbinState;

    public override void TriggerInteraction()
    {
        currentTrashbinState = TrashBin.GetBool("isOpen");
        TrashBin.SetBool("isOpen", !currentTrashbinState);

        if (!currentTrashbinState)
        {
            commandText = "Schließen";
        }
        else 
        {
            commandText = "Öffnen";
        }
    }
}
