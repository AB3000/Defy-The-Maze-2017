using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerGround : MonoBehaviour {
	public GameObject model;
	// Use this for initialization
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			StartCoroutine (lowerGround ());
		}
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator lowerGround(){
		for (int i = 0; i < 10; i = i + 1) {
			model.transform.position = model.transform.position + new Vector3 (0.0f, -i, 0.0f);
			yield return new WaitForSeconds (0.01f);
		}
	}

}