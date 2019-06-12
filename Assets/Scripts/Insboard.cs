using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localPosition = new Vector3 (-21.0f, 1.136995f, 0.1816406f);
		GameObject.Find ("Initial UI").transform.position = new Vector3 (0.1f, 0.08f, 0.1816406f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Button.inst) {
			transform.localPosition = new Vector3 (0.316299f, 1.136995f, 0.1816406f);
			GameObject.Find ("Initial UI").transform.position = new Vector3 (-21.0f, 0.08f, 0.1816406f);
		} else if(!Button.exit){
			transform.localPosition = new Vector3 (-21.0f, 1.136995f, 0.1816406f);
			GameObject.Find ("Initial UI").transform.position = new Vector3 (0.1f, 0.08f, 0.1816406f);
		}
	}
}
