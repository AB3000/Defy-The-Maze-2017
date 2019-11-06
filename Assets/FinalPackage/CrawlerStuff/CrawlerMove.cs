using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrawlerMove : MonoBehaviour {
	public Rigidbody rigidBody;
	public GameObject Target;
	bool jump = true;
	Animator animate;
	public bool attack;
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		animate = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		double distance = Vector3.Distance (gameObject.transform.position, Target.gameObject.transform.position);
		if (distance < 2) {
			if (jump) {
				animate.SetInteger ("state", 2);
				StartCoroutine(WaitToJump (0.5f));
				jump = false;
			}
		} else if (distance < 10) {
			animate.SetInteger ("state", 1);
		}
	}
	void Jump(){
		if (!attack) {
			rigidBody.AddForce (Vector3.up * 1000f);
		}
		StartCoroutine(WaitToDestroy(1.0f));
	}
	IEnumerator WaitToDestroy(float flo){
		yield return new WaitForSeconds (flo);
		Destroy (gameObject);
	}
	IEnumerator WaitToJump(float flo){
		yield return new WaitForSeconds (flo);
		Jump ();
	}
}
