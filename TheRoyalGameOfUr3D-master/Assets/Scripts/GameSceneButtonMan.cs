using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtonMan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void Home(){
		SceneManager.LoadScene (0);
	}
	public void PlayAgain(){
		SceneManager.LoadScene (1);
	}
}
