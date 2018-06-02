using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualObjectCamera : MonoBehaviour {

	public Transform player1;
	public Transform player2;
	public float Fix;


	public float mindistance;
	public float maxdistance;

	void start(){

	}

	void Update () {

		float distance = (player1.position.x - player2.position.x)*Fix;
		float center = (player1.position.x+player2.position.x)/2;

		/*Debug.Log ("Distance " + distance);*/

		if (distance < mindistance) {
			distance = mindistance;
		} else if (distance > maxdistance) {
			distance = maxdistance;
		}


		transform.position = new Vector3 (center, transform.position.y, distance);

	}
}
