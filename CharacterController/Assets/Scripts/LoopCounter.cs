using UnityEngine;
using System.Collections;

public class LoopCounter : MonoBehaviour {

	public int Loop_Counter;

	public GameObject smile;
	public GameObject scarf;
	public GameObject remember;
	public GameObject room;
	public GameObject eyes;
	public GameObject box;
	public GameObject night;



	void OnTriggerEnter2D (Collider2D other) {
		
	Loop_Counter ++;
		
	}

	void Update () {

		smile.SetActive (false);
		scarf.SetActive (false);
		remember.SetActive (false);
		room.SetActive (false);
		eyes.SetActive (false);
		box.SetActive (false);
		night.SetActive (false);
		


		if (Loop_Counter == 2) {
			smile.SetActive (true);
			
		}if (Loop_Counter == 3) {
			scarf.SetActive (true);
			
		}if (Loop_Counter == 4) {
			remember.SetActive (true);
			
		}if (Loop_Counter == 5) {
			room.SetActive (true);
			
		}if (Loop_Counter == 7) {
			eyes.SetActive (true);
			
		}if (Loop_Counter == 8) {
			box.SetActive (true);
			
		}if (Loop_Counter == 10) {
			night.SetActive (true);
			
		}
		
		}

}
