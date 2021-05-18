using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StickmanAgent : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject player;

    public float runDistance;

    private Animator animator;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < runDistance)
        {
            animator.SetBool("isEscape", true);
            Vector3 directionAgent = transform.position - player.transform.position;

            transform.rotation = Quaternion.LookRotation(-directionAgent);

            Vector3 newPosition = transform.position + directionAgent;

            agent.SetDestination(newPosition);
        }
       
    }
}
