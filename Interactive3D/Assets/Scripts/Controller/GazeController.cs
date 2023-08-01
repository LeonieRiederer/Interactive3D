using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GazeController : MonoBehaviour
{

    public float maxDistance = 5;

    public TextMeshProUGUI contextLabel;

    public GameObject contextLabelContainer;

    private InteractableObject currentGazeObject;

    private InteractableTeleport currentTeleportObject;

    private RectTransform contextLabelTransform;

    // Start is called before the first frame update
    void Start()
    {
         contextLabelTransform = contextLabel.GetComponent<RectTransform>();
    }

    void FixedUpdate()
    {
      Vector3 forward = Camera.main.transform.forward;
      Vector3 origin = Camera.main.transform.position;
      RaycastHit hit;

      if (Physics.Raycast(origin, forward, out hit, maxDistance) &&
          hit.collider.gameObject.GetComponent<InteractableObject>() != null ||
          hit.collider.gameObject.GetComponent<InteractableTeleport>() != null)
      {
        Debug.DrawRay(origin, forward * hit.distance, Color.green);

        contextLabelContainer.SetActive(true);
        currentGazeObject = hit.collider.gameObject.GetComponent<InteractableObject>();
        currentTeleportObject = hit.collider.gameObject.GetComponent<InteractableTeleport>();
        contextLabel.text = currentGazeObject.commandText;

        LayoutRebuilder.ForceRebuildLayoutImmediate(contextLabelTransform);
      }
      else
      {
        Debug.DrawRay(origin, forward * maxDistance, Color.red);

        contextLabelContainer.SetActive(false);
        contextLabel.text = "";
        currentGazeObject = null;
        currentTeleportObject = null;
      }
    }

    // Update is called once per frame
    // Which Object is selected
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && currentGazeObject != null)
        {
         if(currentGazeObject) currentGazeObject.TriggerInteraction();
        }

        if(Input.GetKeyDown(KeyCode.F) && currentGazeObject != null)
        {
         if(currentTeleportObject) currentTeleportObject.TriggerTeleport();
        }
    }
}
