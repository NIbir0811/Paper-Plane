using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_obj : MonoBehaviour {

	public GameObject star;
	public float speed_star,flag,flag1;
	public float position_y, position_x;

	// Use this for initialization
	void Start () {
		speed_star = 4.0f;
		flag = 0;
		flag1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(!Plane_control.is_colliding)
			transform.Translate (Vector3.left * speed_star * Time.deltaTime);

		if (transform.position.x <= 5 && flag==0) 
		{

			Star_Gen();   //generating new bars
			flag=1;
		}


		if (transform.position.x <= 5 && flag1==0) 
		{
			flag1=1;
		}


		if (transform.position.x <= -11)
			Destroy (gameObject);


		
	}

	void Star_Gen() //new bar clone
	{
		position_y = Random.Range (-1.5f, 5.0f);
		position_x = Random.Range (10.0f, 15.0f);
		speed_star = Random.Range (3.8f, 4.3f);
		Instantiate (star, new Vector3 (position_x, position_y, -0.5f), Quaternion.Euler (new Vector3 (0, 0, 0)));
	}

	IEnumerator OnTriggerEnter (Collider collider){
		if(gameObject != null)
			GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (0.1f);
		Destroy (gameObject);
		Score.score += 1;
	}
}
