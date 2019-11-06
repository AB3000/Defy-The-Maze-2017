using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrawlerNav : MonoBehaviour {
	public GameObject Target;
	NavMeshAgent navMesh;
	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent> ();
		navMesh.speed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		navMesh.SetDestination (Target.transform.position);
		double distance = Vector3.Distance (gameObject.transform.position, Target.gameObject.transform.position);
		if (distance < 2)
			navMesh.speed = 1.5f;
		else if (distance < 10)
			navMesh.speed = 5f;
	}
}
