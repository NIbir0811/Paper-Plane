using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int score;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		score = 0;
		GetComponent<TextMesh>().text = "" + score;
		GameObject.Find ("score board").transform.position = new Vector3 (-21.0f, 1.31f, -0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = "" + score;
		GameObject.Find ("scoreover").GetComponent<TextMesh> ().text = "Score\n" + score;

		if (Time.timeScale == 0) {
			GameObject.Find ("score board").transform.position = new Vector3 (-0.61f, 1.31f, -1.0f);
			GetComponent<AudioSource> ().Stop();
		}
	}
}
