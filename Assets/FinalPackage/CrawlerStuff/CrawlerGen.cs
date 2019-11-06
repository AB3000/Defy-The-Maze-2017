using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CrawlerGen : MonoBehaviour {
	public GameObject crawler;
	public bool first;
	public GameObject genPoint;
	public GameObject Target;

	// Use this for initialization
	void Start () {
		first = true;
	}
	void OnTriggerEnter(Collider other){
		Vector3 gen = genPoint.transform.position;
		if (other.gameObject.tag == "Player") {
			if (first) {
				GameObject newG = Instantiate (crawler, gen, Quaternion.identity);
				newG.gameObject.GetComponent<CrawlerNav> ().Target = Target;
				newG.GetComponentInChildren<CrawlerMove> ().Target = Target;
			}
			first = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
