using UnityEngine;
using System.Collections;

public class Rotata : MonoBehaviour {

	public bool ChangeAngle;


	void OnTriggerEnter2D (Collider2D other) {

		ControllerScript cs = other.GetComponent<ControllerScript> ();

	


		cs.ChangeAngle = true;




		}



}
