using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Canvas gameOverCanvas;
	public Button playAgainButton;
	// Use this for initialization
	void Start () {
		playAgainButton.onClick.AddListener (PlayAgain);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartGame(){
		
	}

	public void GameOver(){
		gameOverCanvas.enabled = true;
	}

	void PlayAgain(){
		SceneManager.LoadScene ("play");
	}
}
