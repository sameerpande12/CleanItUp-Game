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
    private void Update()
    {
        if(scoreScript.count==0)
        {
            GameObject dust_temp = GameObject.Find("black_bin2d");
            dust_temp.transform.position = new Vector2(Random.Range(400f, 600f), Random.Range(60, 200));
            scoreScript.count = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        if (this.tag == "BlueBin")
        {
            if(other.tag == "BlueWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
                scoreScript.count = scoreScript.count + 1;
                

            }
            else if(other.tag == "GreenWaste" || other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points - 3;
                scoreScript.count = 0;
            }

        }
        else if(this.tag == "GreenBin")
        {

            if (other.tag == "GreenWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
                scoreScript.count = scoreScript.count + 1;
                

            }
            else if (other.tag == "BlueWaste" || other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points - 3;
                scoreScript.count = 0;
            }

        }
        else if(this.tag == "BlackBin")
        {
            if (other.tag == "BlackWaste")
            {
                scoreScript.points = scoreScript.points + 5;
                timerScript.timeLeft = timerScript.timeLeft + 2;
                scoreScript.count = scoreScript.count + 1;
                

            }
            else if (other.tag == "BlueWaste" || other.tag == "GreenWaste")
            {
                Debug.Log("Penalizing");
                scoreScript.points = scoreScript.points - 3;
                scoreScript.count = 0;
            }
        }

        Destroy(other);


    }
}
