using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : InteractableObject
{
    public Animator openDoor;

    public bool currentStateDoor;

    public override void TriggerInteraction()
    {
        currentStateDoor = openDoor.GetBool("doorOpened");
        openDoor.SetBool("doorOpened", !currentStateDoor);
    }

    void Update()
    {
 
    }

}