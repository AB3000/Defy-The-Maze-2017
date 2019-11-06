using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLight : MonoBehaviour {
	public GameObject light1;

	// Use this for initialization
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			StartCoroutine (ChangingLight ());
		}
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator ChangingLight(){
		for (int i = 0; i < 70; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (8-i*0.1f, 8-i*0.1f, 8-i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.01f);

		for (int i = 0; i < 60; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.01f);

		for (int i = 0; i < 50; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a-i*0.1f, light1.GetComponent<Light>().color.a-i*0.1f, light1.GetComponent<Light>().color.a-i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.01f);


		for (int i = 0; i < 40; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.01f);


		for (int i = 0; i < 30; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a-i*0.1f, light1.GetComponent<Light>().color.a-i*0.1f, light1.GetComponent<Light>().color.a-i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}
		yield return new WaitForSeconds (0.01f);


		for (int i = 0; i < 20; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}

		yield return new WaitForSeconds (0.01f);

		for (int i = 0; i < 5; i = i + 1) {
			light1.gameObject.GetComponent<Light> ().color = new Color (light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f, light1.GetComponent<Light>().color.a+i*0.1f);
			yield return new WaitForSeconds (0.01f);
		}

		yield return new WaitForSeconds (0.01f);

	}//End of function

}

//put script in a collider cube