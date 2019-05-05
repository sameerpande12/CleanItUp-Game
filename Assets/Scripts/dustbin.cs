using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dustbin : MonoBehaviour
{
    // Start is called before the first frame update
    private score scoreScript;
    private GameObject scoreObject;
    private GameObject timeObject;
    private timerScript timerScript;
     void Start()
    { scoreObject = GameObject.Find("ScoreKeeper");
      scoreScript = scoreObject.GetComponent<score>() ;
        timeObject = GameObject.Find("TimeKeeper");
        timerScript = scoreObject.GetComponent<timerScript>();
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        
        if (other.tag == "Projectile" && (!timerScript.isTimeUp))
        {
            scoreScript.points = scoreScript.points + (int)(timerScript.timeLeft+1);
            Destroy(other);
        }

    }
}
