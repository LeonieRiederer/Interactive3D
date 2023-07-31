using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFridgeLight : MonoBehaviour
{

    public GameObject fridgeLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            fridgeLight.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Z))
            fridgeLight.SetActive(true);

    }
}
