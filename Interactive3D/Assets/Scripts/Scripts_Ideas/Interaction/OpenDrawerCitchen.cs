using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawerCitchen : InteractableObject
{
    public Animator moveDrawerCitchen;

    private bool currentStateDrawerCitchen1;

    public override void TriggerInteraction()
    {
        currentStateDrawerCitchen1 = moveDrawerCitchen.GetBool("drawerCitchenOpened");
        moveDrawerCitchen.SetBool("drawerCitchenOpened", !currentStateDrawerCitchen1);
    }
}


