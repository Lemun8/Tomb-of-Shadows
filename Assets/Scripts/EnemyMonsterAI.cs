using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMonsterAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator aiAnim;
    int randNum;
    public Transform playerTrans, aiTrans, randDest1, randDest2, randDest3, randDest4, randDest5, randDest6, randDest7, randDest8,
    randDest9, randDest10, randDest11, randDest12, randDest13, randDest14, randDest15, randDest16, randDest17, randDest18, randDest19,
    randDest20, randDest21, randDest22, randDest23;
    public bool walking, chasing, idle;
    Vector3 dest;
    public float chaseTime, idleTime;

    void Start()
    {
        walking = true;
        randNum = Random.Range(0, 22);
        aiAnim.SetTrigger("walk");
        if (randNum == 0)
        {
            dest = randDest1.position;
        }
        if (randNum == 1)
        {
            dest = randDest2.position;
        }
        if (randNum == 2)
        {
            dest = randDest3.position;
        }
        if (randNum == 3)
        {
            dest = randDest4.position;
        }
        if (randNum == 4)
        {
            dest = randDest5.position;
        }
        if (randNum == 5)
        {
            dest = randDest6.position;
        }
        if (randNum == 6)
        {
            dest = randDest7.position;
        }
        if (randNum == 7)
        {
            dest = randDest8.position;
        }
        if (randNum == 8)
        {
            dest = randDest9.position;
        }
        if (randNum == 9)
        {
            dest = randDest10.position;
        }
        if (randNum == 10)
        {
            dest = randDest11.position;
        }
        if (randNum == 11)
        {
            dest = randDest12.position;
        }
        if (randNum == 12)
        {
            dest = randDest13.position;
        }
        if (randNum == 13)
        {
            dest = randDest14.position;
        }
        if (randNum == 14)
        {
            dest = randDest15.position;
        }
        if (randNum == 15)
        {
            dest = randDest16.position;
        }
        if (randNum == 16)
        {
            dest = randDest17.position;
        }
        if (randNum == 17)
        {
            dest = randDest18.position;
        }
        if (randNum == 18)
        {
            dest = randDest19.position;
        }
        if (randNum == 19)
        {
            dest = randDest20.position;
        }
        if (randNum == 20)
        {
            dest = randDest21.position;
        }
        if (randNum == 21)
        {
            dest = randDest22.position;
        }
        if (randNum == 22)
        {
            dest = randDest23.position;
        }
       
    }
    void Update()
    {
        if (walking == true)
        {
            ai.destination = dest;
            ai.speed = 3;
        }
        if (chasing == true)
        {
            dest = playerTrans.position;
            ai.destination = dest;
            ai.speed = 6;
        }
        if (idle == true)
        {
            ai.speed = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chasing = true;
            walking = false;
            idle = false;
            aiAnim.ResetTrigger("idle");
            aiAnim.ResetTrigger("walk");
            aiAnim.SetTrigger("run");
            StopCoroutine("nextDest");
            StopCoroutine("chase");
            StartCoroutine("chase");
        }
        if (other.CompareTag("destination"))
        {
            if (chasing == false)
            {
                idle = true;
                walking = false;
                aiAnim.ResetTrigger("walk");
                aiAnim.SetTrigger("idle");
                StartCoroutine("nextDest");
            }
        }
    }
    IEnumerator nextDest()
    {
        yield return new WaitForSeconds(idleTime);
        idle = false;
        walking = true;
        aiAnim.ResetTrigger("idle");
        aiAnim.SetTrigger("walk");
        randNum = Random.Range(0, 22);
        if (randNum == 0)
        {
            dest = randDest1.position;
        }
        if (randNum == 1)
        {
            dest = randDest2.position;
        }
        if (randNum == 2)
        {
            dest = randDest3.position;
        }
        if (randNum == 3)
        {
            dest = randDest4.position;
        }
        if (randNum == 4)
        {
            dest = randDest5.position;
        }
        if (randNum == 5)
        {
            dest = randDest6.position;
        }
        if (randNum == 6)
        {
            dest = randDest7.position;
        }
        if (randNum == 7)
        {
            dest = randDest8.position;
        }
        if (randNum == 8)
        {
            dest = randDest9.position;
        }
        if (randNum == 9)
        {
            dest = randDest10.position;
        }
        if (randNum == 10)
        {
            dest = randDest11.position;
        }
        if (randNum == 11)
        {
            dest = randDest12.position;
        }
        if (randNum == 12)
        {
            dest = randDest13.position;
        }
        if (randNum == 13)
        {
            dest = randDest14.position;
        }
        if (randNum == 14)
        {
            dest = randDest15.position;
        }
        if (randNum == 15)
        {
            dest = randDest16.position;
        }
        if (randNum == 16)
        {
            dest = randDest17.position;
        }
        if (randNum == 17)
        {
            dest = randDest18.position;
        }
        if (randNum == 18)
        {
            dest = randDest19.position;
        }
        if (randNum == 19)
        {
            dest = randDest20.position;
        }
        if (randNum == 20)
        {
            dest = randDest21.position;
        }
        if (randNum == 21)
        {
            dest = randDest22.position;
        }
        if (randNum == 22)
        {
            dest = randDest23.position;
        }
        
    }
    IEnumerator chase()
    {
        yield return new WaitForSeconds(chaseTime);
        chasing = false;
        walking = true;
        aiAnim.ResetTrigger("idle");
        aiAnim.ResetTrigger("run");
        aiAnim.SetTrigger("walk");
        randNum = Random.Range(0, 22);
        if (randNum == 0)
        {
            dest = randDest1.position;
        }
        if (randNum == 1)
        {
            dest = randDest2.position;
        }
        if (randNum == 2)
        {
            dest = randDest3.position;
        }
        if (randNum == 3)
        {
            dest = randDest4.position;
        }
        if (randNum == 4)
        {
            dest = randDest5.position;
        }
        if (randNum == 5)
        {
            dest = randDest6.position;
        }
        if (randNum == 6)
        {
            dest = randDest7.position;
        }
        if (randNum == 7)
        {
            dest = randDest8.position;
        }
        if (randNum == 8)
        {
            dest = randDest9.position;
        }
        if (randNum == 9)
        {
            dest = randDest10.position;
        }
        if (randNum == 10)
        {
            dest = randDest11.position;
        }
        if (randNum == 11)
        {
            dest = randDest12.position;
        }
        if (randNum == 12)
        {
            dest = randDest13.position;
        }
        if (randNum == 13)
        {
            dest = randDest14.position;
        }
        if (randNum == 14)
        {
            dest = randDest15.position;
        }
        if (randNum == 15)
        {
            dest = randDest16.position;
        }
        if (randNum == 16)
        {
            dest = randDest17.position;
        }
        if (randNum == 17)
        {
            dest = randDest18.position;
        }
        if (randNum == 18)
        {
            dest = randDest19.position;
        }
        if (randNum == 19)
        {
            dest = randDest20.position;
        }
        if (randNum == 20)
        {
            dest = randDest21.position;
        }
        if (randNum == 21)
        {
            dest = randDest22.position;
        }
        if (randNum == 22)
        {
            dest = randDest23.position;
        }
        
    }
}

