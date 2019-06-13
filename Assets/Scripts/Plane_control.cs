using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_control : MonoBehaviour {

	public static bool is_colliding;
	public Vector3 Jumpforce;     //jumpforce for jumping
	public Rigidbody rb;        //for gravity

	// Use this for initialization
	void Start () {
		Jumpforce = new Vector3 (0, 100, 0);

		rb = GetComponent<Rigidbody> (); // to access the components

		is_colliding = false;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {  // Jump with touch
			Jumpforce = new Vector3 (0, 300, 0);
			rb.velocity = Vector3.zero;
			rb.AddForce (Jumpforce);

		}
		else {

			Physics.gravity = new Vector3 (0, -15, 0);    //fall without touch 
		}


	}
	IEnumerator OnCollisionEnter(Collision collision)  // collision detection
	{		
		is_colliding = true;
		GetComponent<AudioSource> ().Play ();
		transform.eulerAngles = new Vector3 (0, 0, -50);
		Physics.gravity = new Vector3 (0, -30, 0);
		yield return new WaitForSeconds (1.5f);
		Time.timeScale = 0f;
	}
}
