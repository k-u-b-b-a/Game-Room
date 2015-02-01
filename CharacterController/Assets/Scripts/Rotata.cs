using UnityEngine;
using System.Collections;

public class Rotata : MonoBehaviour {

	public bool ChangeAngle;


	void OnTriggerEnter2D (Collider2D other) {

		ControllerScript cs = other.GetComponent<ControllerScript> ();

		camera cam = Camera.main.GetComponent<camera> ();


		cs.ChangeAngle = true;

		cam.ChangeAngle = true;


		}



}
