using UnityEngine;
using System.Collections;

public class shoot_button : MonoBehaviour
{
    // Use this for initialization
    public projectile projectile_to_decide;
    void Start()
    {
        projectile_to_decide = GameObject.FindObjectOfType(typeof(projectile)) as projectile;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            Vector2 temp_pos = touch.position;
            if (temp_pos[0] < 380 && temp_pos[0] > 220 && temp_pos[1] < 143 && temp_pos[1] > 113)
            {
                if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                {
                    float time_elaps = touch.deltaTime;
                    Debug.Log("Value Sent= " + time_elaps);
                    projectile_to_decide.ShootProjectilePower(time_elaps * 2.5f);
                }
            }
        }
    }
}
