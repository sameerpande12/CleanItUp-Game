using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour
{
                 //Floating point variable to store the player's movement speed.

    private Rigidbody2D rigidBody;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private CircleCollider2D mycollider;
    private GameObject pointer;
    private GameObject shootButton;
    private GameObject[] garbage;
    private Vector2 initialPosition;
    private int currentGarbage = 0;
    private int garbageCount = 0;
    Vector2 zero_vector;
    Vector2 vector_temp;
    
    private timerScript timer;
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        garbage = new GameObject[transform.childCount];
        garbageCount = transform.childCount;
        initialPosition = transform.GetChild(0).position;
        for(int i = 0; i < transform.childCount; i++)
        {
            garbage[i]= transform.GetChild(i).gameObject;
        }

        rigidBody = garbage[0].GetComponent<Rigidbody2D>();
        rigidBody.bodyType = RigidbodyType2D.Kinematic;
        pointer = GameObject.Find("pointer");
        zero_vector = Vector2.zero;
        shootButton = GameObject.Find("Button");


        timer = GameObject.Find("TimeKeeper").GetComponent<timerScript>();
        //Debug.Log("Start Complete");
    }

   

    public void ShootProjectile() {
   //     Debug.Log("Entered shootProjectile()\n");
        if (rigidBody.isKinematic && pointer.GetComponent<SpriteRenderer>().enabled && (!timer.isTimeUp))
        {
     //       Debug.Log("Entered if in shoot");
            
                rigidBody.velocity = pointer.transform.position - garbage[currentGarbage].transform.position;
                rigidBody.bodyType = RigidbodyType2D.Kinematic;
                rigidBody.isKinematic = false;
            //pointer.GetComponent<SpriteRenderer>().enabled = false ;
            StartCoroutine(updateGun(currentGarbage));

        }

    }

     IEnumerator updateGun(int garbageIndex)
    {
        
        yield return new WaitForSeconds(1);
        currentGarbage = currentGarbage + 1;
        if (currentGarbage < garbageCount)
        {
            rigidBody = garbage[currentGarbage].GetComponent<Rigidbody2D>();
            rigidBody.transform.position = initialPosition;
            rigidBody.bodyType = RigidbodyType2D.Kinematic;
            rigidBody.transform.position = initialPosition;
        }
        else
        {
            yield return new WaitForSeconds(10);
            Debug.Log("Show Score Screen");

        }

        yield return new WaitForSeconds(9)//object deleted automatically after 10 seconds;
        if(garbage[garbageIndex] != null)
        {
            Destroy(garbage[garbageIndex]);
        }
        
        
    }
    

}
