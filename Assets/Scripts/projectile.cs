﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
                 //Floating point variable to store the player's movement speed.

    private Rigidbody2D rigidBody;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private CircleCollider2D mycollider;
    private GameObject pointer;
    Vector2 zero_vector;
    Vector2 vector_temp;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.bodyType = RigidbodyType2D.Kinematic;
        pointer = GameObject.Find("pointer");
        zero_vector = Vector2.zero;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    private void FixedUpdate()
    {
        
    }
         

}
