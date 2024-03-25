using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Powerup2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Power();
        }
    }
    private void Power()
    {
        GetComponent<NavMeshAgent>().speed += 0.25f;
    }
}
