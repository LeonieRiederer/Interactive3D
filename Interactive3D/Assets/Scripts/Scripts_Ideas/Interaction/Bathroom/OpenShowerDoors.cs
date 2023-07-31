using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShowerDoors : InteractableObject
{
    public Animator openFrontDoor;
    public Animator openSideDoor;

    public bool currentStateDoor;

    public override void TriggerInteraction()
    {
        currentStateDoor = openFrontDoor.GetBool("doorOpened");
        openFrontDoor.SetBool("doorOpened", !currentStateDoor);

        currentStateDoor = openSideDoor.GetBool("doorOpened");
        openSideDoor.SetBool("doorOpened", !currentStateDoor);
    }

    void Update()
    {

    }

}
