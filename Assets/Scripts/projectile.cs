using System.Collections;
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
        if (rigidBody.isKinematic && pointer != null)
        {
            if (Input.GetKey(KeyCode.Return))
            {

                rigidBody.velocity = pointer.transform.position - this.transform.position;
                rigidBody.bodyType = RigidbodyType2D.Kinematic;
                rigidBody.isKinematic = false;
                Destroy(pointer);
            }

        }

    }
    /* if (Input.touchCount > 0 &&  rigidBody.isKinematic && pointer != null)
        {
            Touch touch = Input.GetTouch(0);

            // Handle finger movements based on touch phase.
            switch (touch.phase)
            {
                // Record initial touch position.
                case TouchPhase.Began:
                    TouchTime = Time.time;​
                    break;

                // Determine direction by comparing the current touch position with the initial one.
                case TouchPhase.Moved:
                   
                    break;

                // Report that a direction has been chosen when the finger is lifted.
                case TouchPhase.Ended:
                    float velocity=Time.time-TouchTime;              
                    vector_temp = pointer.transform.position - this.transform.position;
                    rigidBody.bodyType = RigidbodyType2D.Kinematic;
                    float angle=Vector2.angle(vector_temp, zero_vector);
                    Vector2 new_vel= (velocity*cos(angle),velocity*sin(angle));
                    rigidBody.velocity=new_vel;                   
                    rigidBody.isKinematic = false;
                    Destroy(pointer);                   
                    break;
            }
        }

         */

}
