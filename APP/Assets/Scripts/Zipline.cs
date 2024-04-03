using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zipline : MonoBehaviour
{
    [SerializeField] float speed;
    public Transform Start;
    public Transform end;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Start")
        {
            float wensez = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, end.position, wensez);

        }
    }

}
