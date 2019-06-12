using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {


	private bool music_playing;
	public static bool inst,exit;
	// Use this for initialization
	void Start () {
		music_playing = true;
		inst = false;
		exit = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (transform.name == "restart") {
			transform.localPosition = new Vector3 (-5.5f, 0.0f, -0.6f);
			Application.LoadLevel ("Gameplay");
		} else if (transform.name == "Play") {
			transform.localPosition = new Vector3 (2.17f, 2.32f, 0.0f);
			Application.LoadLevel ("Gameplay");
		} else if (transform.name == "menu") {
			transform.localPosition = new Vector3 (6.9f, 0.0f, -0.6f);
			Application.LoadLevel ("Game_menu");
		} else if (transform.name == "leaderboard") {
			transform.localPosition = new Vector3 (0.58f, -3.75f, -0.6f);
		} else if (transform.name == "Ins") {
			transform.localPosition = new Vector3 (0.45f, 0.15f, 0.0f);
			inst = true;
		} else if (transform.name == "Sound") {
			transform.localPosition = new Vector3 (3.78f, 0.15f, 0.0f);
			if (music_playing) {
				GameObject.Find ("Menu_background").GetComponent<AudioSource> ().Pause ();
				music_playing = false;
			} else if (!music_playing) {
				GameObject.Find ("Menu_background").GetComponent<AudioSource> ().Play ();
				music_playing = true;
			}
		} else if (transform.name == "Back") {
			transform.localPosition = new Vector3 (-7.0f, 3.3f, -0.6f);
			inst = false;
		} else if (transform.name == "yes") {
			transform.localPosition = new Vector3 (1.54f, -1.1369f, -0.8f);
			Application.Quit ();
			print ("Quit");
		} else if (transform.name == "no") {
			transform.localPosition = new Vector3 (-1.96f, -1.1369f, -0.8f);
			exit = false;
		}
			



			

		if (transform.name == "Exit") {
			transform.localPosition = new Vector3 (7.47f, -2.99f, 0.0f);
			exit = true;
		}
			

	}
	void OnMouseUp(){
		if (transform.name == "restart") {
			transform.localPosition = new Vector3 (-5.5f, 0.0f, -0.5f);
		} else if (transform.name == "menu") {
			transform.localPosition = new Vector3 (6.9f, 0.0f, -0.5f);
		} else if (transform.name == "leaderboard") {
			transform.localPosition = new Vector3 (0.58f, -3.75f, -0.5f);
		} else if (transform.name == "Ins") {
			transform.localPosition = new Vector3 (0.45f, 0.15f, -0.6f);
		} else if (transform.name == "Sound") {
			transform.localPosition = new Vector3 (3.78f, 0.15f, -0.6f);
		} else if (transform.name == "Back") {
			transform.localPosition = new Vector3 (-7.0f, 3.3f, -0.8f);
		} else if (transform.name == "Exit") {
			transform.localPosition = new Vector3 (7.47f, -2.99f, -0.6f);
		} else if (transform.name == "yes") {
			transform.localPosition = new Vector3 (1.54f, -1.1369f, -0.9f);		
		} else if (transform.name == "no") {
			transform.localPosition = new Vector3 (-1.96f, -1.1369f, -0.9f);
		}
	}
}
