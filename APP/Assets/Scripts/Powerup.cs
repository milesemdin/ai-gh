using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Powerup : MonoBehaviour
{
    public NavMeshAgent agent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Humaniod"))
        {
            Pickup();
        }
    }
    public void Pickup()
    {
        Destroy(gameObject);
        
    }
}
