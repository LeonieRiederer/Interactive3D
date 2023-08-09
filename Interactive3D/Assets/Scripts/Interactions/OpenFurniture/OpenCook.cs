using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCook : InteractableObject
{
    public Animator Cook;

    private bool currentCookState;

    public GameObject [] Dampfen;

    private bool currentDampfenState;

    public override void TriggerInteraction()
    {
        currentCookState = Cook.GetBool("isOpen");
        Cook.SetBool("isOpen", !currentCookState);

        currentDampfenState = Dampfen[0].activeSelf;
        for (int i = 0; i<Dampfen.Length; i++){
            Dampfen[i].SetActive(!currentDampfenState);
        }

        if (!currentCookState)
        {
            commandText = "Kochen Aus";
        }
        else 
        {
            commandText = "Kochen";
        }
    }
}
