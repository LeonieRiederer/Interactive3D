using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorLeft : MonoBehaviour
{
    public Animator moveDoorLeft;

    private bool currentStateDoorLeft;



    private void OnTriggerEnter(Collider other)
    {
        currentStateDoorLeft = moveDoorLeft.GetBool("doorOpened");
        moveDoorLeft.SetBool("doorOpened", !currentStateDoorLeft);
    }

    private void OnTriggerExit(Collider other)
    {
        currentStateDoorLeft = moveDoorLeft.GetBool("doorOpened");
        moveDoorLeft.SetBool("doorOpened", !currentStateDoorLeft);
    }
}

