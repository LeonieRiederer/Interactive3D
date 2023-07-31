using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridge : InteractableObject
{
    public Animator moveFridge;

    public bool currentStateFridge;

    public GameObject fridgeLight;

    public override void TriggerInteraction()
    {
        currentStateFridge = moveFridge.GetBool("fridgeOpened");
        moveFridge.SetBool("fridgeOpened", !currentStateFridge);
    }

    void Update()
    {
        if (currentStateFridge == true)
            fridgeLight.SetActive(false);

        if(currentStateFridge == false)
            fridgeLight.SetActive(true);

    }

}
