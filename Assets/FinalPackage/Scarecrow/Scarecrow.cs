using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class Scarecrow : MonoBehaviour {
	public GameObject player;
	NavMeshAgent navMesh;
	public float cos;
	public float sin;
	Animator animate;
	Rigidbody playerRigBod;
	public bool leave = false;
	public bool wait = false;
	SpriteRenderer render;
	Vector3 playerPos;
	// Use this for initialization
	void Start () {
		navMesh = GetComponent<NavMeshAgent> ();
		double beginningAngle = Camera.main.transform.eulerAngles.y;
		cos = (float)Math.Cos(beginningAngle * (Math.PI / 180.0));
		sin = (float)Math.Sin(beginningAngle * (Math.PI / 180.0));
		animate = GetComponent<Animator> ();
		playerRigBod = player.gameObject.GetComponent<Rigidbody> ();
		render = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!leave) {
			playerPos = player.gameObject.transform.position;
			Vector3 newPos = new Vector3 (playerPos.x - (sin)/2, 0, playerPos.z - (cos)/2);
			navMesh.SetDestination (newPos);
			gameObject.transform.LookAt (playerPos);
			if (playerRigBod.velocity.magnitude <= 0) {
				animate.SetBool ("isMove", false);
				navMesh.speed = 0;
				gameObject.transform.LookAt (playerPos);
			} else {
				navMesh.speed = 3.5f;
				animate.SetBool ("isMove", true);
			}
		}
		if (render.isVisible&&!leave) {
			gameObject.transform.LookAt (playerPos);
			Leave ();
		}
		if(leave&&wait)
			gameObject.transform.Translate (Vector3.down*0.005f);
	}
	void Leave(){
		if (!leave) {
			animate.SetBool ("isMove", false);
			navMesh.speed = 0;
			leave = true;
			navMesh.enabled = false;
			StartCoroutine (WaitToLook (0.5f));
		}
	}
	IEnumerator WaitToLook(float i){
		yield return new WaitForSeconds (i);
		wait = true;
		StartCoroutine (WaitToDestroy ());
	}
	IEnumerator WaitToDestroy(){
		yield return new WaitForSeconds (4);
		Destroy (gameObject);
	}
}
