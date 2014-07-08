using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform myTransform;

	public int playerSpeed = 5;

	// Use this for initialization
	void Start () {
		// Spawn point

		myTransform = transform;

		myTransform.position = new Vector3 (-3, -3, -1);
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * playerSpeed);
	}
}
