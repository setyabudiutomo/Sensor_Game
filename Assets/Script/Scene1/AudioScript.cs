using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
    public AudioClip musicClip;

    public AudioSource MusicSource;

	// Use this for initialization
	void Start () {
        MusicSource.clip = musicClip;
	}
}
