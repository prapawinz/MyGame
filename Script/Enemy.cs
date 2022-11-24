using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    Animator animator;
    public Transform player;
    private NavMeshAgent enemy;
    public float checkDistance = 10.0f;
    public float walkCheckDistance = 5.0f;
    public float enemyEyesAngle = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        enemy = GetComponent<NavMeshAgent>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);
        


        if (Vector3.Distance(player.position, transform.position) < checkDistance)
        {
            direction.y = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            


            if(direction.magnitude > walkCheckDistance)
            {
                transform.Translate(0, 0, 0.03f);
                animator.SetBool("isFastRun", true);
                animator.SetBool("isPoseing", false);               
            }
            
        }
        else
        {
            animator.SetBool("isFastRun", false);
            animator.SetBool("isPoseing", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);        
    }
  
}
