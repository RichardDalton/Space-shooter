using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Transform myTransform;

	public int playerSpeed = 15;

	// variable to reference prefab - prefab = gameobject

	public GameObject ProjectileFab;


	// Use this for initialization
	void Start () {

		myTransform = transform;

		// Spawn point
		myTransform.position = new Vector3 (0, -3, -1);
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime);

		Vector3 position = myTransform.position;

		if (position.x > 6.5f) {
			myTransform.position = new Vector3(-6.5f, position.y, position.z);
		} else if (position.x < -6.5f) {
			myTransform.position = new Vector3(6.5f, position.y, position.z);
		}

		// press space bar to fire a laser

		// if the player presses down the space bar a laser will shoot out

		if (Input.GetKeyDown (KeyCode.Space)) {

			Vector3 projectilePosition = new Vector3(position.x, -2, position.z);

			// file projectile
			Instantiate(ProjectileFab, projectilePosition, Quaternion.identity);
		}
	}
}
