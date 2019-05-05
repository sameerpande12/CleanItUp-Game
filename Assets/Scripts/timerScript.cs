using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public Text timerText;
    public int timeLeft ;
    public int timeLimit = 50;//in seconds
    private float startTime;
    public bool isTimeUp = false;
    // Start is called before the first frame update
    void Start()
    {
        isTimeUp = false;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLimit- (int)(Time.time - startTime);
        if (timeLeft > 0)
        {
            string minutes = ((int)(timeLeft / 60)).ToString();
            string seconds = (timeLeft % 60).ToString();
            timerText.text = minutes + ":" + seconds;
        }
        else
        {
            isTimeUp = true;
            timerText.text = "Time Up!";
        }
    }
}
