using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        if (this.tag == "BlueBin")
        {
            if(other.tag == "BlueWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
              

            }
            else if(other.tag == "GreenWaste" || other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points - 3;
            }

        }
        else if(this.tag == "GreenBin")
        {

            if (other.tag == "GreenWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
                

            }
            else if (other.tag == "BlueWaste" || other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points - 3;
            }

        }
        else if(this.tag == "BlackBin")
        {
            if (other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
                

            }
            else if (other.tag == "BlueWaste" || other.tag == "GreenWaste")
            {
                Debug.Log("Penalizing");
                scoreScript.points = scoreScript.points - 3;
            }
        }

        Destroy(other);


    }
}
