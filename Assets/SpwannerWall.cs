using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwannerWall : MonoBehaviour {

	public GameObject upWall;
	public GameObject downWall;
	private GameObject player;

	public float distance = 6.0f;
	public float upWallCenter = 2.3f;
	public float downWallCenter = -2.3f;



	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x - player.transform.position.x < 10) {
			MoveAndCreateWall ();
		}
	}

	private void MoveAndCreateWall(){
		Move ();
		CreateWall ();
	}

	private void Move(){
		transform.position = new Vector3 (transform.position.x + distance, transform.position.y, transform.position.z);
	}

	private void CreateWall(){
		bool isTop  = (Random.value > 0.5f);
		if (isTop) {
			Instantiate(upWall, new Vector3(transform.position.x, upWall.transform.position.y, upWall.transform.position.z), Quaternion.identity);
		} else {
			Instantiate(downWall, new Vector3(transform.position.x, downWall.transform.position.y, upWall.transform.position.z), Quaternion.identity);
		}
	}

}
