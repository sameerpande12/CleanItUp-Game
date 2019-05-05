using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
                 //Floating point variable to store the player's movement speed.

    private Rigidbody2D rigidBody;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private CircleCollider2D mycollider;
    private GameObject pointer;
    private GameObject shootButton;
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
        shootButton = GameObject.Find("Button");
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    /*private void FixedUpdate()
    {
        if (rigidBody.isKinematic && pointer != null) {
            if (Input.GetButton("Shoot"))
            {
                rigidBody.velocity = pointer.transform.position - this.transform.position;
                rigidBody.bodyType = RigidbodyType2D.Kinematic;
                rigidBody.isKinematic = false;
                Destroy(pointer);

            }

        }
    }*/

       
     public void ShootProjectile() {
        if (rigidBody.isKinematic && pointer != null)
        {
         
            
                rigidBody.velocity = pointer.transform.position - this.transform.position;
                rigidBody.bodyType = RigidbodyType2D.Kinematic;
                rigidBody.isKinematic = false;
                Destroy(pointer);

            

        }

    }
         

}
