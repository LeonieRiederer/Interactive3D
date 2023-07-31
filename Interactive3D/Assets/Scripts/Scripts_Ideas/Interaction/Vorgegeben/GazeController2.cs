using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GazeController2 : MonoBehaviour
{
    public float rayDistance = 5;
    public TextMeshProUGUI commandLabel; 

    private InteractableObject currentGazedObject;
    private RectTransform contextLabelTransform;
    public GameObject commandPanel;

    // Start is called before the first frame update
    void Start() {
        contextLabelTransform = commandLabel.GetComponent<RectTransform>();
    }

    void FixedUpdate() {
        Vector3 forward = Camera.main.transform.forward; 
        Vector3 origin = Camera.main.transform.position;

        RaycastHit hit; 

        if(Physics.Raycast(origin, forward, out hit, rayDistance) &&
        hit.collider.gameObject.GetComponent<InteractableObject>() != null ) {
            Debug.DrawRay(origin, forward * hit.distance, Color.green);
            
            commandPanel.SetActive(true);

            currentGazedObject = hit.collider.gameObject.GetComponent<InteractableObject>();
            commandLabel.text = currentGazedObject.commandText;
        }
        else {
            Debug.DrawRay(origin, forward * rayDistance, Color.red);

            currentGazedObject = null;
            commandLabel.text = "";
            commandPanel.SetActive(false);
        }

        LayoutRebuilder.ForceRebuildLayoutImmediate(contextLabelTransform);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && currentGazedObject != null) {
            currentGazedObject.TriggerInteraction();
        }
    }
}
