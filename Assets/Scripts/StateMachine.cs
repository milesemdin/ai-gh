using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum States
    {

        Attack,
        Patrol,
        Idle,
    }


    public States state = States.Idle;
    public int x = 0;
    public void Update()
    {
        Debug.Log(x);
    }

    void Start()
    {
        NextState();
    }
    void NextState()
    {
        switch (state)
        {
            case States.Attack:
                StartCoroutine(AttackState());
                break;
            case States.Patrol:
                StartCoroutine(PatrolState());
                break;

            case States.Idle:
                StartCoroutine (IdleState());
                break;
            default:
                Debug.LogError("State Not included in NextState");
                break;

        }
    }
    IEnumerator AttackState()
    {
        Debug.Log("Attack ONE");
        yield return new WaitForSeconds(1);
        Debug.Log("Attack Two");
        while (state == States.Attack)
        {
            x *= 2;
            if (x > 100000)
            {
                state = States.Idle;
            }
            yield return null;
        }
       NextState();
        
    }
    IEnumerator PatrolState()
    {
        Debug.Log("Patrolling");
        while (state == States.Patrol)
        {
            x -= 1;
            if (x < 0) 
            {
                state = States.Idle;
            }
            yield return null;
        }
        NextState();
    }
    IEnumerator IdleState()
    {
        Debug.Log("idling");
        while (state == States.Idle)
        {
            yield return null;
        }
        if (state == States.Idle)
            NextState();

    }
}

