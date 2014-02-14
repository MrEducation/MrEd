﻿using UnityEngine;
using System.Collections;

public class GroundScroll : MonoBehaviour {

	float Speed = 0.75f;


	// Update is called once per frame
	void Update () {

		float movement = Speed * Time.deltaTime;
		transform.Translate (Vector3.left * movement);

		if (transform.position.x < -2.861909F) 
		{
			transform.position = new Vector3(2.861909f, transform.position.y, transform.position.z);
		}


	}
}
