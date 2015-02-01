using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	float angle = 0f;

	public bool ChangeAngle;

	public Transform target;

	public float speed;

	// Use this for initialization
	void Start () {

		ChangeAngle = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ChangeAngle == true) {





				float step = speed * Time.deltaTime;
				transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
				ChangeAngle = false;
			
		}
	
}
}