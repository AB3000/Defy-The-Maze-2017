using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour {
	
	//public GameObject landmark;
	public AudioClip Verse;
	AudioSource audioSource;
	//public GameObject thing;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			//audioSource.PlayOneShot(Verse, 0.7F);
			//thing.gameObject.GetComponent<Animator> ().SetBool ("isTrigged", true);
			audioSource.Play();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
