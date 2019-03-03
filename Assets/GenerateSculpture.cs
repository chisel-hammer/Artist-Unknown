using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class GenerateSculpture : MonoBehaviour {
	float size = 0.00625F;
	public Transform sculpture;

	public Transform cube;

	// Use this for initialization
	void Start () {
		GenerateColumn();
	}

	/** Creates a 2D layer of cubes of size 'size' at position (0, y, 0) */
	void GenerateLayer (float y) {
		for (int i = -7; i < 8; i++){
			for (int j = -7; j < 8; j++){
				Transform newCube = Instantiate(cube, new Vector3(i*size, y, j*size), Quaternion.identity);
				newCube.parent = sculpture;
			}
		} 
	}

	void GenerateColumn(float y = 0){
		for (int i = -17; i < 18; i++){
			GenerateLayer(i*size);
		}
	}
}
