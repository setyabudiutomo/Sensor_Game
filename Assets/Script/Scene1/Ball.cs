using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    public AudioSource tickSource;

    void Start() 
    {
        tickSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Box") 
        {
            Destroy(col.gameObject);
            tickSource.Play();
            Data.box += 1;
            MoveScene();
        }
    }

    void MoveScene() 
    {
        if (Data.box == 4) 
        {
            SceneManager.LoadScene("Coba");
        }
    }
}
