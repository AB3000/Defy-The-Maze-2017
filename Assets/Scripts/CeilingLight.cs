using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingLight : MonoBehaviour {
	public GameObject light1, brick;

	// Use this for initialization
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player"){
			StartCoroutine (ChangingLight ());
		}
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator ChangingLight(){
		for (int i = 0; i< 25; i = i +1){
			light1.gameObject.GetComponent<Light>().color= new Color(178, 255, (0.2f*i),0.6f);
			brick.GetComponent<Renderer>().material.color =  new Color (178, 255, (0.2f*i),0.6f);
			yield return new WaitForSeconds (0.1f);
			brick.GetComponent<Renderer>().material.color =  new Color (178, 255, (0.1f*i),0.6f);
			light1.gameObject.GetComponent<Light>().color= new Color(178, 255, (0.1f*i),0.6f);
			yield return new WaitForSeconds (0.1f);
		}

		yield return new WaitForSeconds (0.01f);
		light1.gameObject.GetComponent<Light> ().color = Color.red;
		for (int i = 0; i< 10; i = i +1){
			brick.GetComponent<Renderer>().material.color =  new Color (255, (0.2f*i), (0.2f*i),0.6f);
			light1.gameObject.GetComponent<Light>().color =  new Color (255, (0.2f*i), (0.2f*i),0.6f);
			yield return new WaitForSeconds (0.1f);
			light1.gameObject.GetComponent<Light>().color =  new Color (255, (0.1f*i), (0.1f*i),0.6f);
			brick.GetComponent<Renderer>().material.color =  new Color (255, (0.1f*i), (0.1f*i),0.6f);
			yield return new WaitForSeconds (0.1f);
		}
		//light1.gameObject.GetComponent<Light> ().color = Color.green;



	}
}

