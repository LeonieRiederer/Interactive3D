using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawers : InteractableObject
{    
    public Animator openBottomDrawer;

    public Animator openTopDrawer;


    private bool currentStateDrawer;

    public override void TriggerInteraction()
    {
         currentStateDrawer = openBottomDrawer.GetBool("drawerOpened");
        openBottomDrawer.SetBool("drawerOpened", !currentStateDrawer);     
        
        currentStateDrawer = openTopDrawer.GetBool("drawerOpened");
        openTopDrawer.SetBool("drawerOpened", !currentStateDrawer);
    }
}
