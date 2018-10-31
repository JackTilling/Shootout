using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleScript : MonoBehaviour {
	
	private bool destroyed;

	// Use this for initialization
	void Start () {
		Debug.Log("LOADED BOTTLE");
		destroyed = false;
	}	

	private void OnMouseDown() {
		if (!destroyed) {
			destroyed = true;
			Debug.Log("_Destroyed_");

			GameObject.Find("GameManager").GetComponent<GameManagerScript>().scoreCount++;
			Debug.Log(GameObject.Find("GameManager").GetComponent<GameManagerScript>().scoreCount);
		}
	}
}
