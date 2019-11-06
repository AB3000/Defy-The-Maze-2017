using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAlternate: MonoBehaviour {
	public GameObject light1, light2;
	// Use this for initialization
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Player"){
			StartCoroutine (ChangingLight());
		}
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator ChangingLight(){
		for (int i = 0; i< 100000; i = i +1){
			light1.SetActive(false);
			light2.SetActive(true);
			yield return new WaitForSeconds (0.1f);
			light1.SetActive(true);
			light2.SetActive(false);
			yield return new WaitForSeconds (0.1f);
		}
	}	
}