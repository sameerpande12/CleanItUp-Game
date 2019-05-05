using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dustbin : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag == "Projectile")
        {
            Destroy(other);
        }

    }
}
