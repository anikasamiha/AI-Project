using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonMAn : MonoBehaviour {

	public GameObject AboutUSPanel;
	public GameObject PlayPanel;
	public GameObject MenuPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}


	public void Play(){
		PlayPanel.SetActive (true);
		MenuPanel.SetActive (false);
	}
	public void AboutUs(){
		AboutUSPanel.SetActive (true);
		MenuPanel.SetActive (false);
	}
	public void Back(){
		AboutUSPanel.SetActive (false);
		PlayPanel.SetActive (false);
		MenuPanel.SetActive (true);
	}
	public void Exit(){
		Application.Quit ();
	}
	public void SinglePlayer(){
		PlayerPrefs.SetInt ("AI",1);
		SceneManager.LoadScene (1);
	}
	public void TwoPlayer(){
		PlayerPrefs.SetInt ("AI",0);
		SceneManager.LoadScene (1);
	}
}
