using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            // run the addpoint function in scoreManager
            ScoreManager.instance.AddPoint(); 

        }
    }

    
}

