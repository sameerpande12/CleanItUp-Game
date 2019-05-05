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
        timerScript = timeObject.GetComponent<timerScript>();
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        
        if (other.tag == "Projectile" )
        {
            scoreScript.points = scoreScript.points +5;
            timerScript.timeLeft = timerScript.timeLeft + 2;//bonus for hitting
            Destroy(other);
        }

    }
}
