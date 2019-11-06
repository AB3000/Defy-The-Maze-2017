using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderGen: MonoBehaviour {
	public GameObject goat;
	public bool first;
	// Use this for initialization
	void Start () {
		first = true;
	}
	void OnTriggerEnter(Collider other){
		bool Boolean  = (Random.value > 0.5f);
		Vector3 genPoint = gameObject.transform.position;
		if (Boolean) {
			genPoint.Set (gameObject.transform.position.x + 3, 0, gameObject.transform.position.z + 2);
			if (other.gameObject.tag == "Player") {
				if (first) {
					GameObject newG = Instantiate (goat, genPoint, Quaternion.identity);
					newG.gameObject.transform.Rotate (gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y - 90, gameObject.transform.eulerAngles.z);
					goat.GetComponent<SpiderMove> ().movement = true;
				}
				first = false;
			}
		} else {
			genPoint.Set (gameObject.transform.position.x - 3, 0, gameObject.transform.position.z + 2);
			if (other.gameObject.tag == "Player") {
				if (first) {
					GameObject newG = Instantiate (goat, genPoint, Quaternion.identity);
					newG.gameObject.transform.Rotate (gameObject.transform.eulerAngles.x, gameObject.transform.eulerAngles.y + 90, gameObject.transform.eulerAngles.z);
					goat.GetComponent<SpiderMove> ().movement = true;
				}
				first = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
