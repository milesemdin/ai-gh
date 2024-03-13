using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 open;
    public Vector3 close;
    public float moveSpeed = 5f;
    private void Start()
    {
        close = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == ("Humaniod"))
        {
            Open();
        }
        else
        {
            
        }
    }
    void Open()
    {
        Vector3.MoveTowards(transform.position, open, moveSpeed);
    }
}
