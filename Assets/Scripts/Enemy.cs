using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public LayerMask playerMask;
    public NavMeshAgent agent;
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Collider[] objs;
        objs = Physics.OverlapSphere(transform.position, 10, playerMask);
        foreach (var obj in objs)
        {
            {
                if (Vector3.Distance(obj.transform.position, transform.position) < 10)
                {
                    agent.SetDestination(obj.transform.position);
                }
            }
        }
    }
}