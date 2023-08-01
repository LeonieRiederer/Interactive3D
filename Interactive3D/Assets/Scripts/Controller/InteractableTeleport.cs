using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableTeleport : MonoBehaviour
{
    public string commandText; 

    public abstract void TriggerTeleport();
}
