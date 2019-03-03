using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class Carve : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider collider) {
		print("Carve");
		if (collider.transform.parent.name.Equals("index")) {
			
			transform.gameObject.SetActive(false);
		}	
	}
}
