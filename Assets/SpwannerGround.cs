﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwannerGround : MonoBehaviour {

	public GameObject ground;
	private GameObject player;
	public float distance = 18.55f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x - player.transform.position.x < 25) {
			CreateGroundAndMove ();
		}
	}

	private void CreateGroundAndMove(){
		CreateGround ();
		Move ();
	}

	private void Move(){
		transform.position = new Vector3(transform.position.x + distance, transform.position.y,transform.position.z);
	}

	private void CreateGround(){
		Instantiate(ground, transform.position, Quaternion.identity);
	}
}
