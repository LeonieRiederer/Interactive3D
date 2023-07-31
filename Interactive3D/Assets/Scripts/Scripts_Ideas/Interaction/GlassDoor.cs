using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoor : MonoBehaviour
{
    public Animator moveDoorRight;

    private bool currentStateDoorRight;

   
   
    private void OnTriggerEnter(Collider other)
    {
        currentStateDoorRight = moveDoorRight.GetBool("doorOpened");
        moveDoorRight.SetBool("doorOpened", !currentStateDoorRight);
    }

    private void OnTriggerExit(Collider other)
    {
        currentStateDoorRight = moveDoorRight.GetBool("doorOpened");
        moveDoorRight.SetBool("doorOpened", !currentStateDoorRight);
    }
}

