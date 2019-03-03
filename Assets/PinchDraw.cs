using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class PinchDraw : MonoBehaviour {

	// Use this for initialization
	int frameSkipCounter;

	PinchDetector pinchDetector;
	public HandModelBase handModel;

	public Transform cube;

	public Transform sculpture;
	
	void Start () {
		frameSkipCounter = 0;
		pinchDetector = new PinchDetector();
		pinchDetector.HandModel = handModel;
	}
	
	// Update is called once per frame
	void Update () {
		if (!checkForDrawingFrame()) {
			return;
		}

		if (!pinchDetector.IsPinching) {
			return;
		}

		Transform newCube = Instantiate(cube, pinchDetector.LastActivePosition, Quaternion.identity);
		newCube.parent = sculpture;
	}

	bool checkForDrawingFrame() {
		if (frameSkipCounter < 9) {
			frameSkipCounter++;
			return false;
		} else {
			frameSkipCounter = 0;
			return true;
		}
	}

	public bool isPinching() {
		return pinchDetector.IsPinching;
	}
}
