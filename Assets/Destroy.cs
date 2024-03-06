using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Destroy : MonoBehaviour
{
    public NavMeshAgent humanoid;
    // Start is called before the first frame update
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Humaniod"))
       {
             Destroy(collision.gameObject);
        }
    }

}
