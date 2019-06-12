using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_obs : MonoBehaviour {
	
	public GameObject[] cars;
	public float speed_cars,flag,flag1,position_x,position_y;
	public int indx;
	private float speed_upper, speed_lower;
	private int checkscore;
	// Use this for initialization
	void Start () {
		speed_cars = 4.5f;
		flag = 0;
		flag1 = 0;
		position_x = 0;
		speed_lower = 4.0f;
		speed_upper = 5.5f;
		checkscore = 20;
	}

	// Update is called once per frame
	void Update () {
		if(!Plane_control.is_colliding)
			transform.Translate (Vector3.left * speed_cars * Time.deltaTime);

		if (Score.score >= checkscore) {
			speed_lower += 1.0f;
			speed_upper += 1.0f;
			checkscore += 20;
		}

		if (transform.position.x <= 10 && flag==0) 
		{

			Car_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= 5 && flag1==0) 
		{
			flag1=1;
		}

		if (transform.position.x <= -11)
			Destroy (gameObject);
		
	}

	void Car_Gen(){
		indx = Random.Range (0,15);
		position_x = Random.Range (15.0f, 25.0f);
		position_y = Random.Range (-2.0f, -1.5f);
		speed_cars = Random.Range (speed_lower, speed_upper);
		Instantiate (cars[indx], new Vector3 (position_x, position_y, -0.5f), Quaternion.identity);
	}

}
