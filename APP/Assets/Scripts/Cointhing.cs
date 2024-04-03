using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cointhing : MonoBehaviour
{
    public int collectedObjects = 0;
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "collectable")
        {
            collectedObjects++;
            Destroy(collision.gameObject);
        }
    }
}
