﻿using UnityEngine;
using System.Collections;

public class InstatiatePipe : MonoBehaviour {


	void pipeInstance()
	{
		Instantiate(Resources.Load("Pipe Prefab"), new Vector3(1.720725F,Random.Range (-0.4659623F, 1.397567F),-0.04970127F) , Quaternion.identity);
	}

	bool GameStarted = false;

	void Start()
	{

	}
	

	void Update () {


		if (Input.GetMouseButton (0) && GameStarted == false)
		{
			GameStarted = true;
			InvokeRepeating ("pipeInstance", 2, 2.0F);
		}
		
	}
}
