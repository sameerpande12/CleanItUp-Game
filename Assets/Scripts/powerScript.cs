using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class powerScript : MonoBehaviour
{
    private Scrollbar powerBar;
    public static float power;
    // Start is called before the first frame update
    void Start()
    {
        powerBar = GetComponent<Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        powerBar.value = (Time.time) % 1;
        power = powerBar.value;
    }
}
