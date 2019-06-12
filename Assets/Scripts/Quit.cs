using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Button.exit) {
			transform.localPosition = new Vector3 (0.3f, 1.1f, 0.1816406f);
			GameObject.Find ("Initial UI").transform.position = new Vector3 (-21.0f, 0.08f, 0.1816406f);
		} else {
			transform.localPosition = new Vector3 (-21.0f, 1.1f, 0.1816406f);
			//GameObject.Find ("Initial UI").transform.position = new Vector3 (0.1f, 0.08f, 0.1816406f);
		}
	}
}
