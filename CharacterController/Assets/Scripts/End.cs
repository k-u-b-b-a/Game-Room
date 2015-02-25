using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	public int Loop_Counter;
	public bool EndofGame;

	void OnTriggerEnter2D (Collider2D other) {
		
		LoopCounter cs = other.GetComponent<LoopCounter> ();

		EndofGame = false;

		if (Loop_Counter == 9){
			EndofGame = true;
		}

		if (EndofGame = true){
			Time.timeScale = 0;
		}
		
	}


}
