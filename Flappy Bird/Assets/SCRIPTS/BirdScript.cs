using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour {

	// Use this for initialization
	bool gameStarted = false;
	bool isDown = false;
	bool lost = false;

	float rotation = -180.0F;
	float angle;
	float currentAngle;

	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "pipe")
		{
			lost = true;
		}
	}



	// Update is called once per frame
	void Update () {

		angle = rotation * Time.deltaTime;

		if (this.rigidbody2D.velocity.y < 0)
			{
		
				
				currentAngle = this.transform.eulerAngles.z;

			//Debug.Log("Curr angle: " + currentAngle);

				this.transform.Rotate (0, 0, angle);
					
				if(currentAngle < 360 && currentAngle > 270 )
				{
					if(currentAngle < 271)
					{
				  		this.transform.Rotate (0, 0, -angle);
					}
				}
			}

		else if(this.rigidbody2D.velocity.y > 0)
		{
			angle = 0.0F;
		}

		if(!(Input.GetMouseButton(0)))
		{
			isDown = false;
		}

		if(Input.GetMouseButton(0) && gameStarted == false)
		{
			gameStarted = true;
			this.transform.localEulerAngles = new Vector3(0,0,30);
			this.rigidbody2D.gravityScale = 0.5F;
		}

		if(Input.GetMouseButton(0) && isDown == false && lost == false)
		{
			this.rigidbody2D.velocity = new Vector2(0,2F);
			this.transform.localEulerAngles = new Vector3(0,0,30);
			isDown = true;
		}


	}
}
