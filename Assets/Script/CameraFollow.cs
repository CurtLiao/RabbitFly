﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject theCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < theCamera.transform.position.y)
            theCamera.transform.position = new Vector3(theCamera.transform.position.x, transform.position.y, theCamera.transform.position.z);
	}
}
