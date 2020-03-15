using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{
    //desiginates who the player is
    public Transform target;
    public float curHealth, maxHealth, moveSpeed, attackRange, attackSpeed, noiseRange, sense;
    public NavMeshAgent agent;

    //gives distances for how far away the player will be when they switch behaviour
    public float dist, sightDist;
    public bool Detected;
    public GameObject self;
    //public GameObject playerShadow;
    public float turnSpeed;
    public float sightAngle;
    
    
    public Rigidbody rigid;
  
    public float AttackTimer;
    RaycastHit hit;
    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
    void Start()
    {
        //sets the conditions at the start
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = self.GetComponent<NavMeshAgent>();
        
        sightDist = 100f;
        sightAngle = 90f;

        AttackTimer = attackSpeed;
    }
    public void TakeDamage(float damage)
    {
        curHealth -= damage;
    }
    void Update()
    {


      
            agent.destination = target.position;
        

        
        //kills the enemy when they lose all their health
        if (curHealth <= 0)
        {
            Destroy(self);
        }
        //moves the enemy when the player is alive
        
            dist = Vector3.Distance(target.position, transform.position);

            if (curHealth == 0)
            {
                return;
            }
            //attacks the player if they get too close
            else if (AttackTimer >= 0)
            {
                AttackTimer -= Time.deltaTime;
                Debug.Log("Attack");
                dist = 0;

            }
            else if (AttackTimer > 0)
            {
                Debug.Log("Attack");
                AttackTimer = attackSpeed;
                dist = 0;
            }

            //follows the player when they see him
            


            
        

    }
}
