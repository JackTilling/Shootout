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
	private float randTime;

	// Use this for initialization
	void Start () {
		// SpawnBottle();
		StartCoroutine(StartCountdown(3.0f));
	}

	private void Update() {
	}

	void SpawnBottle() {
		GetRandomValues();

		bottle = Instantiate(bottleObject, transform.position, Quaternion.AngleAxis(rotate, Vector3.forward));
		rb2D = bottle.GetComponent<Rigidbody2D>();
		
		rb2D.isKinematic = false;
		rb2D.AddForce(new Vector2(xForce,yForce));
		StartCoroutine(StartCountdown(randTime));
	}

	void GetRandomValues() {
		xForce = Random.Range(150,230);
		yForce = Random.Range(110,170);
		rotate = Random.Range(-35,35);
		randTime = Random.Range(2.0f,6.0f);
	}

	public IEnumerator StartCountdown(float countdownValue)
	{
		float currCountdownValue = countdownValue;
		while (currCountdownValue > 0)
		{
			yield return new WaitForSeconds(1.0f);
			currCountdownValue--;
		}
		SpawnBottle();
	}
}
