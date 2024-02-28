using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Vector3 deltaPosition;
    private Vector3 _closedPosition;
    private Vector3 _openPosition;
    public float speed = 5f;
    public float waitTime = 3f;
    // Vector3 makes position and the closed position means the variable of what its called

    // Start is called before the first frame update
    void Start()
    {
        _closedPosition = transform.position;
        _openPosition = transform.position + deltaPosition;
    }
    void openDoor()
    {
        if (Input.GetKeyDown("e"));
        {
            Vector3.MoveTowards(transform.position, _openPosition, speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        openDoor();

    }
}
