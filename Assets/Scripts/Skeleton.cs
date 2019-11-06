using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour {
	//private Animation anim;
	public GameObject thing;
	// Use this for initialization
	void Start () {
		//anim.SetActive (false);
		thing.GetComponent<Animator>().enabled = false;
	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "Player") {
			thing.GetComponent<Animator>().enabled = true;
			thing.gameObject.GetComponent<Animator> ().SetBool ("isTrigged", true);
			thing.gameObject.GetComponent<Animator> ().SetBool ("isWalking", true);
			thing.transform.Translate (Vector3.forward);
			thing.gameObject.GetComponent<Animator> ().SetBool ("isAlive", true);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
