﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        transform.Translate(-Input.acceleration.x * 0.1f, 0,Input.acceleration.z * 0.1f);
	}
}
