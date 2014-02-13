using UnityEngine;
using System.Collections;

public class RemovePipe : MonoBehaviour {

	float Speed = 0.75f;
	// Update is called once per frame
	void Update () {


		float movement = Speed * Time.deltaTime;
		transform.Translate (Vector3.left * movement);

		if (transform.position.x < -1.6) 
		{
			Destroy(this.gameObject);
		}

	}
}
