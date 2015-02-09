using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public bool ChangeAngle;



	float angle = 0f;

	public float maxSpeed;



	bool moveRight = true;

	Animator anim;
	float epsilon = 0.01f;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		ChangeAngle = false;


	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey(KeyCode.LeftArrow)) {
			moveRight = false;
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			moveRight = true;
		}
		
		if (moveRight == true) {
						maxSpeed = 2.5f;
		

	
						float move = Input.GetAxis ("Horizontal");

						anim.SetFloat ("Speed", Mathf.Abs (move));

	
		
						if (Mathf.Abs (rigidbody2D.rotation - 0) < epsilon) {
								rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
						} else if (Mathf.Abs (rigidbody2D.rotation - 90) < epsilon || Mathf.Abs(rigidbody2D.rotation + 270) < epsilon) {
								rigidbody2D.velocity = new Vector2 (0, move * maxSpeed);
						} else if (Mathf.Abs (rigidbody2D.rotation - 180) < epsilon || Mathf.Abs(rigidbody2D.rotation + 180) < epsilon) {
								rigidbody2D.velocity = new Vector2 (-move * maxSpeed, 0);
						} else if (Mathf.Abs (rigidbody2D.rotation - 270) < epsilon || Mathf.Abs(rigidbody2D.rotation + 90) < epsilon) {
								rigidbody2D.velocity = new Vector2 (0, -move * maxSpeed);
						} else if (Mathf.Abs (rigidbody2D.rotation - 360) < epsilon) {
								rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
						} 
		}
		
		

		if (moveRight == false) {
			maxSpeed = 0f;
			rigidbody2D.velocity = new Vector2 (0 , 0);
	
				}


	

		//if (rigidbody2D.rotation < 90) {
		//	rigidbody2D.rotation += 1f;
		//}

		if (ChangeAngle == true) {
			rigidbody2D.transform.Rotate (0, 0, 90);
			ChangeAngle = false;
					
		}

		Debug.Log (rigidbody2D.velocity);



	
	}






}
//else if (Mathf.Abs (ridigbody2D.rotation - 180) < epsilon || Mathf.Abs(rigidbody2D.rotation + 360) < epsilon)
