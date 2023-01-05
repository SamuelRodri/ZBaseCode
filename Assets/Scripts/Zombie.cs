using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform target;
    public float speed = 0.5f;
    public float attackRange = 1.4f;
    public Animator animator;
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        float dist = Vector3.Distance(target.position, transform.position);
        
        if (dist > attackRange)// && !isAttacking)
        {
            var targetV = new Vector3(target.position.x, 0f, target.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetV, speed * Time.deltaTime);
        }
        else
        {
  //          if (!isAttacking)
    //        {
                // ATTACK
//                isAttacking = true;
                animator.SetBool("isNearPlayer", true);
                //
      //      }            
        }
    }
}