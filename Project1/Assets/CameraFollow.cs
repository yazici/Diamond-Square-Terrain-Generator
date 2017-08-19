﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    // Use this for initialization

    private float speedH = 2.0f;
    private float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 55.0f;

	private float rot = 0.0f;

    void Start()
    {

    }

    int speed = 25;
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("e")) {
			this.rot -= 1.0f;
		}
		if (Input.GetKey("q")) {
			this.rot += 1.0f;
		}
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, rot);

        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");
        //Vector3 moveVector = (transform.forward * v) + (transform.right * h);

		if (Input.GetKey(KeyCode.LeftShift)) {
			speed = 25 * 10;
		} else {
			speed = 25;
		}

		if (Input.GetKey("w"))
		{
			transform.position += this.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey("s"))
		{
			transform.position -= this.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey ("a")) {
			transform.position -= this.transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			transform.position += this.transform.right * speed * Time.deltaTime;
		}

       // moveVector *= speed * Time.deltaTime;
       // transform.localPosition += moveVector;

    }
}
