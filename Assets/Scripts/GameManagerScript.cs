using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public int scoreCount = 0;
	public int bottlesThrown = 0;
	
	private Text hitsUI;

	// Use this for initialization
	void Start () {
		hitsUI = GameObject.FindWithTag("HitsUI").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		hitsUI.text = "HITS = " + scoreCount.ToString();
		Debug.Log(bottlesThrown);
	}
}
