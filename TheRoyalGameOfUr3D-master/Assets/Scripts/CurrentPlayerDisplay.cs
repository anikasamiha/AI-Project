using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CurrentPlayerDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        theStateManager = GameObject.FindObjectOfType<StateManager>();
       // myText = GetComponent<Text>();
	}
	public TextMeshProUGUI turn;
    StateManager theStateManager;
   // Text myText;

    // TODO: Consider a humanizer library
    string[] numberWords = { "White", "Red", "Three", "Four" };
	
	// Update is called once per frame
	void Update () {

      //  myText.text = "Current Player: " + numberWords[theStateManager.CurrentPlayerId];
		turn.text="Current Player: " + numberWords[theStateManager.CurrentPlayerId];

	}
}
