using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Door : MonoBehaviour
{
    private Vector3 open;
    private Vector3 close;
    public bool closed = true;
    public float moveSpeed = 5f;
    public Transform door;
    public Transform thing;

    private void Start()
    {
        GetComponent<BoxCollider>();
        closed = true;
       
    }
    void Opened()
    {
        closed = false;
        Debug.Log("wow");
        door.position = thing.transform.position * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Humaniod")
        {
            Opened();
            
        }
    }
}
