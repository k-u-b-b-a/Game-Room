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
	public GameObject black;
	public GameObject door_closed;
	public GameObject door_almostClosed;
	public GameObject frame_1 , frame_2 , frame_3;
	public GameObject squareFrame_1, squareFrame_2, squareFrame_3, squareFrame_4, squareFrame_5; 
	public float myTimer = 0.0f;




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
		black.SetActive (false);
		door_closed.SetActive(false);
		door_almostClosed.SetActive (false);
		frame_1.SetActive (true);
		frame_2.SetActive (false);
		frame_3.SetActive (false);
		squareFrame_1.SetActive (true);
		squareFrame_2.SetActive (false);
		squareFrame_3.SetActive (false);
		squareFrame_4.SetActive (false);
		squareFrame_5.SetActive (false);


		if (myTimer >= 3.1f) {
			black.SetActive (true);
			Time.timeScale  = 0;}



		if (Loop_Counter == 1) {
			smile.SetActive (true);



			
		}if (Loop_Counter == 2) {
			scarf.SetActive (true);
			frame_2.SetActive (false);

			
		}if (Loop_Counter == 4) {
			remember.SetActive (true);
			door_almostClosed.SetActive (true);
			frame_2.SetActive(true);

			
		}if (Loop_Counter == 5) {
			room.SetActive (true);
			squareFrame_3.SetActive(true);
			frame_2.SetActive(true);
			door_almostClosed.SetActive (true);

			
		}if (Loop_Counter == 6) {
			eyes.SetActive (true);
			door_closed.SetActive(true);
			frame_2.SetActive(true);
			squareFrame_4.SetActive(true);


		}if (Loop_Counter == 7) {
			box.SetActive (true);
			frame_3.SetActive(true);
			squareFrame_5.SetActive(true);
			door_closed.SetActive(true);
			
		}if (Loop_Counter == 8) {
			night.SetActive (true);
			frame_3.SetActive(true);
			door_closed.SetActive(true);
			squareFrame_5.SetActive(true);
			
		}if (Loop_Counter == 9) {
			myTimer += Time.deltaTime;
				
				} 
			

		}
		
		

}
