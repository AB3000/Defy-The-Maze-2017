using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CrowGen : MonoBehaviour {
	public GameObject scarecrow;
	public bool first;
	public GameObject player;
	// Use this for initialization
	void Start () {
		first = true;
	}
	void OnTriggerEnter(Collider other){
		double beginningAngle = Camera.main.transform.eulerAngles.y;
		float cos = (float)Math.Cos(beginningAngle * (Math.PI / 180.0));
		float sin = (float)Math.Sin(beginningAngle * (Math.PI / 180.0));
		Vector3 playerPos = player.gameObject.transform.position;
		Vector3 newPos = new Vector3 (playerPos.x - (sin)/2, 0, playerPos.z - (cos)/2);
		if (other.gameObject.name == "player") {
			if (first) {
				GameObject newG = Instantiate (scarecrow, newPos, Quaternion.identity);
				Scarecrow scare = newG.GetComponent<Scarecrow> ();
				scare.player = this.player;
			}
			first = false;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
