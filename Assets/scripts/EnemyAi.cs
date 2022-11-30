using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange=7f;
    float distancetotarget = Mathf.Infinity;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distancetotarget = Vector3.Distance(target.position, transform.position);
        if(distancetotarget<=chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }

    }
}
