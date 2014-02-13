using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

	// Use this for initialization
	bool gameStarted = false;
	bool isDown = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!(Input.GetMouseButton(0)))
		{
			isDown = false;
		}

		if(Input.GetMouseButton(0) && gameStarted == false)
		{
			gameStarted = true;
			this.rigidbody2D.gravityScale = 0.5F;
		}

		if(Input.GetMouseButton(0) && isDown == false)
		{
			this.rigidbody2D.velocity = new Vector2(0,2F);
			isDown = true;
		}


	}
}
