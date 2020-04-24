using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
