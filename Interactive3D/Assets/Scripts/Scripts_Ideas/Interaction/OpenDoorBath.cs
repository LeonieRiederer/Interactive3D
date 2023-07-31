using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorBath : InteractableObject
{
    public Animator moveDoorBath;

    private bool currentStateBath;

    public override void TriggerInteraction()
    {
        currentStateBath = moveDoorBath.GetBool("doorBathOpened");
        moveDoorBath.SetBool("doorBathOpened", !currentStateBath);
    }
}
