using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_move : MonoBehaviour {
	public float speed_background;

	// Use this for initialization
	void Start () {

		speed_background = 2.5f;

	}

	// Update is called once per frame
	void Update () {
		if(! Plane_control.is_colliding)
			transform.Translate (Vector3.left * speed_background * Time.deltaTime);
		if(transform.localPosition.x<=-17.05f)
			transform.localPosition+= new Vector3(2*(17.053f-0.01f),0,0);
	}
}
