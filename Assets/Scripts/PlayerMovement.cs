using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;
   // Start is called before the first frame update
   void Start()
   {
        agent.SetDestination(target.position);
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
