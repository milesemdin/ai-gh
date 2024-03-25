using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation.Samples;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public NavMeshAgent spooker;
    public NavMeshAgent Humanoid;
    void Update()
    {
        spooker.destination = Humanoid.transform.position;
    }
    
}
