using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToucheInput : MonoBehaviour
{
    //public Text score;
    public GameObject bottle1;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {   
            if (hit.transform.tag == "Bottle")
            {
                Destroy(bottle1);
                MoveScene();
            }
        }        
    }

    void MoveScene()
    {
        SceneManager.LoadScene("Cobalagi");
    }
}