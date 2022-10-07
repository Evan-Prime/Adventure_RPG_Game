using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public float sizeModifier = 2.5f;
    public string newName = "DaxCube";
    public bool isRotated = false;

    void Start()
    {
        transform.name = ImproveName(newName);
        
        if (1 + 1 == 2)
        {
            Debug.Log("We're Here!");
        }
    }

    void Update()
    {
        transform.localScale = Vector3.one * sizeModifier;
        

    }

    string ImproveName (string originalString)
    {
        return "-{" + originalString + "}-";
    }

}
