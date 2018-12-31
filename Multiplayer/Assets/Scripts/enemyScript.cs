using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
    
    private UnityEngine.AI.NavMeshAgent m_NavMeshAgent;
    private int m_CurrentWaypoint;

    [SerializeField] private Transform[] m_Waypoints;

    void Start()
    {

        m_CurrentWaypoint = 0;

        m_NavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        m_NavMeshAgent.updatePosition = false;
        m_NavMeshAgent.updateRotation = true;

    }
    
    // Update is called once per frame
    void Update()
    {
        Patrol();
        //CheckPlayer();
        m_NavMeshAgent.nextPosition = transform.position;
        /*
        switch (m_NPCState)
        {
            case NPCState.CHASE:
                Chase();
                break;
            case NPCState.PATROL:
                Patrol();
                break;
            default:
                break;
        }*/
    }

    void Patrol()
    {
        //Debug.Log("Patrolling");

        //CheckWaypointDistance();
        m_NavMeshAgent.SetDestination(m_Waypoints[m_CurrentWaypoint].position);
    }
    /*
    void CheckWaypointDistance()
    {
        if (Vector3.Distance(m_Waypoints[m_CurrentWaypoint].position, this.transform.position) < m_ThresholdDistance)
        {
            m_CurrentWaypoint = (m_CurrentWaypoint + 1) % m_Waypoints.Length;
        }
    }*/
}
