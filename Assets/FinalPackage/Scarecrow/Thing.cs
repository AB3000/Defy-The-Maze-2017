using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Thing : MonoBehaviour {
	public GameObject player;
	NavMeshAgent navMesh;
	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.transform.position;
		Vector3 vect = playerPos - gameObject.transform.position;
		Vector3 newPos;
		if (vect.magnitude > 2) {
			newPos = playerPos;
			navMesh.speed = 3;
		} else {
			newPos = playerPos + vect;
			navMesh.speed = 0;
		}
		navMesh.SetDestination (newPos);
		gameObject.transform.LookAt (playerPos);
	}
}

