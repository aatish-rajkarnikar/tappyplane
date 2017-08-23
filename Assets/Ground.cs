using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void Update () {
		if (transform.position.x - player.transform.position.x < -25){
			Destroy (gameObject);
		}
	}
}
