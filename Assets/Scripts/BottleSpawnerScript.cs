using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawnerScript : MonoBehaviour {

	public GameObject bottleObject;

	private GameObject bottle;
	private Rigidbody2D rb2D;

	private int xForce;
	private int yForce;

	// Use this for initialization
	void Start () {
		// SpawnBottle();
	}

	private void Update() {
		if (Input.GetKeyDown("space"))
        {
            SpawnBottle();
        }
	}

	void SpawnBottle() {
		bottle = Instantiate(bottleObject, transform.position, Quaternion.identity);
		rb2D = bottle.GetComponent<Rigidbody2D>();
		GetForces();
		rb2D.isKinematic = false;
		rb2D.AddForce(new Vector2(xForce,yForce));
	}

	void GetForces() {
		xForce = Random.Range(170,230);
		yForce = Random.Range(90,130);
	}
}
