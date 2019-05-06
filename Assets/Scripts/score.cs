using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public  int points = 0;
    public int count = 0;
    public Text scoreText;
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
