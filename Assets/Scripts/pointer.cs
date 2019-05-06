using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    private float offsetX, offsetY;
    
    private Rigidbody2D myBody;
    private float speed = 1F;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 temp_pos = Input.GetTouch(0).position;
            if (!(temp_pos[0] < 380 && temp_pos[0] > 220 && temp_pos[1] < 143 && temp_pos[1] > 113))
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

                transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
            }
        }
    }
    
}
