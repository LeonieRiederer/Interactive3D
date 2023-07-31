using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCabinetDrawer : InteractableObject
{
    public Animator openDrawer;

    private bool currentDrawerState;

    public override void TriggerInteraction()
    {
        currentDrawerState = openDrawer.GetBool("drawerOpened");
        openDrawer.SetBool("drawerOpened", !currentDrawerState);
    }
}
