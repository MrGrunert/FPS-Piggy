using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterTargeting : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform target;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Pathfind());
	}
    IEnumerator Pathfind()
    {
        while (true)    // corutine
        {
            agent.SetDestination(target.position);
            yield return new WaitForSeconds(0.5f);     
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}
}
