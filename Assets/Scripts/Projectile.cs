using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private Transform myTransform;
	public int projectileSpeed = 3;

	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (myTransform.position.y > 7) {
			DestroyObject(this.gameObject);
		}

		myTransform.Translate (Vector3.up * Time.deltaTime * projectileSpeed);
	}
}
