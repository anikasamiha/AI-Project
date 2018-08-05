using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DiceTotalDisplay : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        theStateManager = GameObject.FindObjectOfType<StateManager>();
    }

    StateManager theStateManager;
	public TextMeshProUGUI score;	
    // Update is called once per frame
    void Update()
    {
        if (theStateManager.IsDoneRolling == false)
        {
            //GetComponent<Text>().text = "= ?";
			score.text = "?";
        }
        else
        {
            //GetComponent<Text>().text = "= " + theStateManager.DiceTotal;
			score.text = theStateManager.DiceTotal.ToString();
        }

    }
}
