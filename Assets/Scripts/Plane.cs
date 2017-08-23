using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

	public float speed = 2;
	public float force = 2;

	private Rigidbody2D rb2d;
	private bool isDead = false;
	private bool isStarted = false;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		if (isStarted && !isDead) {
			if (Input.GetKey (KeyCode.Space) || Input.touchCount > 0) {
				rb2d.AddForce (Vector2.up * force);
			}
		}
	}

	public void Activate(){
		isStarted = true;
		rb2d.gravityScale = 2;
		rb2d.velocity = Vector2.right * speed;
	}
}
