using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleObject : MonoBehaviour
{
    public string commandText;

    public void TriggerInteraction()
    {
      print("Interaktion auslösen");
    }
}
