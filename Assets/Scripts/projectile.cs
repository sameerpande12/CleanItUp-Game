using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        float moveHorizontal = 1f;
        float moveVertical = 1f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveHorizontal += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveVertical += Time.deltaTime;
        }
        //Store the current vertical input in the float moveVertical.


        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal * 30, moveVertical * 30);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.velocity = movement;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal

    }


}
