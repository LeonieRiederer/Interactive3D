using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationInteraction : InteractableObject
{
    // List of GameObjects To Active / Deactivate
    public GameObject[] objectsToActivate;

    void Start()
    {
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(false);
        }
    }
    
    public override void TriggerInteraction()
    {
       for (int i = 0; i < objectsToActivate.Length; i++)
       {
            objectsToActivate[i].SetActive(!objectsToActivate[i].activeInHierarchy);
       }
    }
}
