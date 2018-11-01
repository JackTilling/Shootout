using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawnerScript : MonoBehaviour {

	public GameObject bottleObject;

	private GameObject bottle;
	private Rigidbody2D rb2D;

	private int xForce;
	private int yForce;
	private int rotate;

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
		GetForces();

		bottle = Instantiate(bottleObject, transform.position, Quaternion.AngleAxis(rotate, Vector3.forward));
		rb2D = bottle.GetComponent<Rigidbody2D>();
		
		rb2D.isKinematic = false;
		rb2D.AddForce(new Vector2(xForce,yForce));
	}

	void GetForces() {
		xForce = Random.Range(150,240);
		yForce = Random.Range(70,150);
		rotate = Random.Range(-35,35);
	}
}
