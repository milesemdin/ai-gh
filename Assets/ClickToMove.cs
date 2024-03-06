using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent humaniod;
    // Start is called before the first frame update
    void Start()
    {
        humaniod = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                humaniod.destination = hitInfo.point;
            }

            
        }
    }
}
