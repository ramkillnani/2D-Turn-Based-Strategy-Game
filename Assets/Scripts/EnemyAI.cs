using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    //desiginates who the player is
    public Transform target;
    public float moveSpeed;
    public NavMeshAgent agent;
    


    public GameObject self;

    public float turnSpeed;





    public Rigidbody rigid;


    void Start()
    {


        agent = self.GetComponent<NavMeshAgent>();



    }

    void Update()
    {








       



            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.2f);
            agent.destination = target.position;





        

    }
}


