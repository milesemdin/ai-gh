using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenDoor : MonoBehaviour
{
    public Vector3 deltaPosition;
    private Vector3 _closedPosition;
    private Vector3 _openPosition;
    public float speed = 5f;
    
    // Vector3 makes position and the closed position means the variable of what its called

    // Start is called before the first frame update
    void Start()
    {
        _closedPosition = transform.position;
        _openPosition = (-8,3,23);
    }


    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3.MoveTowards(transform.position, _openPosition, speed);
        }
    }
}
