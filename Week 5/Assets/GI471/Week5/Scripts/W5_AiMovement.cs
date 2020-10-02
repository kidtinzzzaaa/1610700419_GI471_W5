using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class W5_AiMovement : MonoBehaviour
{
    private NavMeshAgent navAgent;
    private W5_PlayerMovement playerTarget;
    private void Start()
    {

    }
    private void Update()
    {
        FindingPlayer();

        

    } 
    private void FindingPlayer()
    {
        if(playerTarget == null)
        {
            playerTarget = FindObjectOfType<W5_PlayerMovement>();
        }
    }
    private void UpdateMovement()
    {
        if(playerTarget == null)
        {
            navAgent.SetDestination(playerTarget.transform.position);
        } return;
        
    }
}
