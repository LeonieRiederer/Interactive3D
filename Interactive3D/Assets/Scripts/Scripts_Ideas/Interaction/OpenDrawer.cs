using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : InteractableObject
{    
    public Animator moveDrawer;

    private bool currentState;

    public override void TriggerInteraction()
    {
        currentState = moveDrawer.GetBool("drawerOpened");
        moveDrawer.SetBool("drawerOpened", !currentState);
    }
}
