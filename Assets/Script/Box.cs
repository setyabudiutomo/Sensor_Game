using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour {
    public Color defaultColor;
    public Color selectedColor;
    private Material mat;

    void Start() 
    {
    }

    void OnTouchDown() 
    {
        mat.color = selectedColor;    
    }
    void OnTouchUp()
    {
        mat.color = defaultColor;
    }
    void OnTouchStay()
    {
        mat.color = selectedColor;
    }
    void OnTouchExit()
    {
        mat.color = defaultColor;
    }
}
