using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMaterialInteraction : InteractableObject
{
    // Array of materials
    public Material[] materials;
    
    // Mesh-Renderer to change
    public MeshRenderer[] renderers; 

    // Index of current selected material
    private int currentIndex;

    void Start() 
    {
        ChangeMaterial(0);
    }

    public override void TriggerInteraction() 
    {
        ChangeMaterial(currentIndex + 1);
    }

    private void ChangeMaterial(int newMaterialIndex) 
    {
        currentIndex = (newMaterialIndex >= materials.Length) ? 0 : newMaterialIndex;

        for (int i = 0; i < renderers.Length; i++ ) 
        {
            renderers[i].material = materials[currentIndex];
        }
    }
}
