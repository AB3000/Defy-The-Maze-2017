using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMove : MonoBehaviour {
	public bool destroyTrigger;
	public bool movement = false;
	public Rigidbody rigidBody;
	public float walkSpeed = 0.05f;
	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody>();
		destroyTrigger = false;
	}
	// Update is called once per frame
	void Update () {
		if(movement)
			gameObject.transform.Translate(Vector3.forward*walkSpeed);
	}
	void OnTriggerExit(Collider other){
		StartCoroutine(WaitToDestroy(2f));
	}
	IEnumerator WaitToDestroy(float i){
		yield return new WaitForSeconds (i);
		Destroy (gameObject);
	}
}
