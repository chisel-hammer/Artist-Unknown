using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapRestart : MonoBehaviour {
	public Transform sculpture;

	void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			Clap();
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider collider) {
		print("Collision");

		if (collider.transform.parent.name.Equals("index") || collider.transform.parent.name.Equals("ring") ) {
			Clap();
		}
	}

	void Clap(){
		for (int i = 0; i < sculpture.childCount; i++) {
			sculpture.GetChild(i).gameObject.SetActive(true);

		}
		print("clap");
	
	}
}
