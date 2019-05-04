using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    private Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool keyPressed = true;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position - new Vector3(1, 0, 0);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(1, 0, 0);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 1, 0);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position - new Vector3(0, 1, 0);
        }
        else keyPressed = false;

        if (keyPressed) {
            StartCoroutine(waitNow());
        }
        
    }
    IEnumerator waitNow() {
        yield return new WaitForSeconds(0.1f);
        myBody.velocity= new Vector2( 0, 0);
    }
    
}
