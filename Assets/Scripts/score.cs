using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public  int points = 0;
    public Text scoreText;
    public int consecutiveHits = 0;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }
    private void Update()
    {
        scoreText.text = "Score: " + points.ToString();
    }

    // Update is called once per frame

}
