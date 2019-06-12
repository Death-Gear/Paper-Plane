using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_obs : MonoBehaviour {

	public GameObject bird;
	public float speed_bird,flag,flag1;
	public float position_y, position_x;
	private float speed_upper, speed_lower;
	private int checkscore;
	// Use this for initialization
	void Start () {
		speed_bird = 4.0f;
		flag = 0;
		flag1 = 0;
		speed_lower = 4.5f;
		speed_upper = 7.0f;
		checkscore = 10;
	}

	// Update is called once per frame
	void Update () {
		if(!Plane_control.is_colliding)
		transform.Translate (Vector3.left * speed_bird * Time.deltaTime);

		if (Score.score >= checkscore) {
			speed_lower += 0.5f;
			speed_upper += 0.5f;
			checkscore += 10;
		}

		if (transform.position.x <= 10 && flag==0) 
		{

			Bird_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= 5 && flag1==0) 
		{
			flag1=1;
		}


		if (transform.position.x <= -11)
			Destroy (gameObject);

	}
	void Bird_Gen() //new bar clone
	{
		position_y = Random.Range (1.0f, 5.0f);
		position_x = Random.Range (15.0f, 20.0f);
		speed_bird = Random.Range (speed_lower, speed_upper);
		Instantiate (bird, new Vector3 (position_x, position_y, -0.5f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}
}
