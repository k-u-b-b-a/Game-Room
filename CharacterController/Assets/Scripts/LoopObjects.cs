using UnityEngine;
using System.Collections;

public class LoopObjects : MonoBehaviour {

	public int Loop_Counter;
	
	public GameObject ceiling;

	// Use this for initialization
	void Start () {
	
		ceiling.SetActive (false);


	
	}
	
	// Update is called once per frame
	void Update () {

		LoopCounter cs = GetComponent <LoopCounter> ();

		cs.Loop_Counter ++;

		if (cs.Loop_Counter == 3) {
			ceiling.SetActive (true);
		}




	}
}
