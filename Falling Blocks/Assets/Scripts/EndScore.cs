using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		float score = GameObject.FindObjectOfType<PlayerScore>().score;
		text.text = "Score: " + score;
		Destroy(GameObject.Find ("PlayerScore"));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
