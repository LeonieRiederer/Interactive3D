using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Define where to teleport
    public Transform destination;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if(other.gameObject.CompareTag("Player"))
        {
            CharacterController ccScript = other.gameObject.GetComponent<CharacterController>();
            ccScript.enabled = false;
            other.transform.position = destination.position;
            other.transform.rotation = destination.rotation;
            ccScript.enabled = true; 
        }
    }
}
