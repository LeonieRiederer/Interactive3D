using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GazeController : MonoBehaviour
{

    public float maxDistance = 5;

    public TextMeshProUGUI contextLabel;
    public TextMeshProUGUI teleportContextLabel;

    public GameObject contextLabelContainer;
    public GameObject teleportContextLabelContainer;

    private InteractableObject currentGazeObject;

    private InteractableTeleport currentTeleportObject;

    private RectTransform contextLabelTransform;
    private RectTransform teleportContextLabelTransform;

    // Start is called before the first frame update
    void Start()
    {
        contextLabelTransform = contextLabel.GetComponent<RectTransform>();
        teleportContextLabelTransform = teleportContextLabel.GetComponent<RectTransform>();
    }

    void FixedUpdate()
    {
      Vector3 forward = Camera.main.transform.forward;
      Vector3 origin = Camera.main.transform.position;
      RaycastHit hit;
      GameObject player = GameObject.FindGameObjectWithTag("Player");

      if (Physics.Raycast(origin, forward, out hit, maxDistance) &&
        hit.collider.gameObject.GetComponent<InteractableObject>() != null)
      {
        Debug.DrawRay(origin, forward * hit.distance, Color.green);

        contextLabelContainer.SetActive(true);
        currentGazeObject = hit.collider.gameObject.GetComponent<InteractableObject>();
        contextLabel.text = "E - " + currentGazeObject.commandText;

        LayoutRebuilder.ForceRebuildLayoutImmediate(contextLabelTransform);
      }
      else
      {
        Debug.DrawRay(origin, forward * maxDistance, Color.red);

        contextLabelContainer.SetActive(false);
        contextLabel.text = "";
        currentGazeObject = null;
      }

    // have teleport as different object and use different key
    if (Physics.Raycast(origin, forward, out hit, maxDistance) &&
        hit.collider.gameObject.GetComponent<InteractableTeleport>() != null)
    {

        Debug.DrawRay(origin, forward * hit.distance, Color.green);
        currentTeleportObject = hit.collider.gameObject.GetComponent<InteractableTeleport>();
        teleportContextLabel.text = "F - " + currentTeleportObject.commandText;
        teleportContextLabelContainer.SetActive(true);
        LayoutRebuilder.ForceRebuildLayoutImmediate(teleportContextLabelTransform);
    
    }
      else
      {
        Debug.DrawRay(origin, forward * maxDistance, Color.red);

        // character controller enabled == not sitting
        if (player.GetComponent<CharacterController>().enabled) {
            currentTeleportObject = null;
            teleportContextLabelContainer.SetActive(false); 
            teleportContextLabel.text = "";
        } else {
            // show updated text immediatly
            teleportContextLabel.text = "F - " + currentTeleportObject.commandText;
            teleportContextLabelContainer.SetActive(true);
            LayoutRebuilder.ForceRebuildLayoutImmediate(teleportContextLabelTransform);
        }
        
      }
    }

    // Update is called once per frame
    // Which Object is selected
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && currentGazeObject)
        {
            currentGazeObject.TriggerInteraction();
        }

        if(Input.GetKeyDown(KeyCode.F) && currentTeleportObject)
        {
            currentTeleportObject.TriggerTeleport();
        }
    }
}
