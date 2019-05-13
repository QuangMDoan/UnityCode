using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    //New instance variable
    [SerializeField]Text textComponent;

	// Use this for initialization
	void Start () {
        textComponent.text = ("Once upon a time...");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
