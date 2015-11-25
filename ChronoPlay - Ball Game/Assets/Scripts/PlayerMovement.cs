﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision other) {
        switch (other.transform.tag)
        {
            case "BlueCheckPoint":
                print("Blue Chosen");
                break;
            case "RedCheckPoint":
                print("Red Chosen");
                break;
            case "GreenCheckPoint":
                print("Green Chosen");
                break;
            default:
                break;
        }      
    }
}
