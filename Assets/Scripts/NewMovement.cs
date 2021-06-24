using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewMovement : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public GameObject player;
    public Animator animator;
    public float speed;
    private Vector3 oldPos;

    // Update is called once per frame
    private void Update()
    {
        //Move Scipt

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                agent.SetDestination(hit.point);
            }
        }

        //check speed script
        speed = Vector3.Distance(oldPos, player.transform.position) * 100f;
        oldPos = player.transform.position;
        if (speed > 0)
        {
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsRunning", false);
        }
        else if (speed >= 10)
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsRunning", false);
        }
    }
}