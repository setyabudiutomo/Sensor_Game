using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Box") 
        {
            Destroy(col.gameObject);
            Data.box += 1;
            MoveScene();
        }
    }

    void MoveScene() 
    {
        if (Data.box == 0) 
        {
            SceneManager.LoadScene("Coba");
        }
    }
}
