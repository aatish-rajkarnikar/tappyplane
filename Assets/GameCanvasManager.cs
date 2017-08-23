using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCanvasManager : MonoBehaviour {

	public SpriteRenderer leftTap;
	public SpriteRenderer rightTap;
	public SpriteRenderer tap;
	public Button startButton;

	void Start () {
		startButton.onClick.AddListener (StartGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartGame(){
		leftTap.enabled = false;
		rightTap.enabled = false;
		tap.enabled = false;
		startButton.enabled = false;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		Plane plane = player.GetComponent<Plane> ();
		plane.Activate ();

	}
}
