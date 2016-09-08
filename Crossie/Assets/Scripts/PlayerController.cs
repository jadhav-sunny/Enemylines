﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rgbd;
    public float playerSpeed;

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void FixedUpdate () 
    {
        float velX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float velY = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        rgbd.velocity = new Vector2(velX, velY);
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "LeftDirection" || other.tag == "RightDirection")
        {
            transform.position = new Vector2(0,-9.6f);
        }
    }
}
