using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if(transform.name=="restart" || transform.name=="Play")
			Application.LoadLevel ("Gameplay");


		if (transform.name == "menu")
			Application.LoadLevel ("Game_menu");

		if (transform.name == "Exit") {
			Application.Quit ();
			print ("quitting");
		}
			

	}
}
