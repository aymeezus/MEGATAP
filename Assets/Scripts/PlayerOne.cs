﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour {

    [SerializeField] private CameraOneRotator cam;
    private int state = 1;

	void Update () {
        state = cam.GetState();

        if (state == 1)
        {
            this.transform.Translate(Input.GetAxis("Horizontal") * 0.25f, 0,0);
        }
        else if(state == 2)
        {
            this.transform.Translate(0, 0, Input.GetAxis("Horizontal") * 0.25f);
        }
        else if(state == 3)
        {
            this.transform.Translate(-Input.GetAxis("Horizontal") * 0.25f, 0, 0);
        }
        else if (state == 4)
        {
            this.transform.Translate(0, 0, -Input.GetAxis("Horizontal") * 0.25f);
        }
    }
}
