using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float MinimumSpeed = 1f;
	public float MaximumSpeed = 5f;
	public float CurrentSpeed = 0;
	public float x, y, z;

	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		CurrentSpeed = Random.Range(MinimumSpeed, MaximumSpeed);

		y = 6;
		z = 0;
		x = Random.Range (-6, 6);
		myTransform.position = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate (Vector3.down * CurrentSpeed * Time.deltaTime);

		if (myTransform.position.y < -7) {
			CurrentSpeed = Random.Range(MinimumSpeed, MaximumSpeed);
			myTransform.position = new Vector3(Random.Range (-6, 6), y, z);
		}
	}
}
