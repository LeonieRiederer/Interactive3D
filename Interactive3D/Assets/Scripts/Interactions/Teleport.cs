using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : InteractableTeleport
{
    
    public Transform teleportPosition;

    private Vector3 currentPlayerPosition;
    private Vector3 currentPlayerRotation;
    public bool currentlySitting;
    private GameObject player;
    private CharacterController controller;
    private string originalCommandText; // Speichert originalen commandText wie Hinsetzen oder Hinlegen

    void Start()
    {
        currentlySitting = false;
    }
    
    void Update()
    {
        if (currentlySitting && Input.GetKeyDown(KeyCode.F))
        {
            // enable controller, move position to old one
            player.transform.position = currentPlayerPosition;
            player.transform.eulerAngles = currentPlayerRotation;
            // wait a bit to signal we stood up
            StartCoroutine(WaitAfterStandUp());
            controller.enabled = true;
            commandText = originalCommandText;
        }
    }

    public override void TriggerTeleport() 
    {
        if (!currentlySitting) TeleportTo();
    }

    // function to teleport to a chair
    private void TeleportTo()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        // save player position only if it is not set yet
        currentPlayerPosition = player.transform.position;
        currentPlayerRotation = player.transform.eulerAngles;

        // disable moving
        controller = player.GetComponent<CharacterController>();
        controller.enabled = false;

        // teleport
        player.transform.position = teleportPosition.position;
        player.transform.rotation = teleportPosition.rotation;

        originalCommandText = commandText;
        commandText = "Aufstehen";
        StartCoroutine(WaitAfterStandUp());
    }

    IEnumerator WaitAfterStandUp()
    {
       yield return new WaitForSeconds(0.1f);
        currentlySitting = !currentlySitting;
    }
}
