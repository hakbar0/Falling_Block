using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

	public float score = 0f;

	public Text text;

	// Use this for initialization

	// Update is called once per frame


	void Start(){
		InvokeRepeating("Scoring", 1.0f, 1.0f);
	}

	void Update () {
		

	}

	void Scoring(){
		if (GameObject.Find("Player")) {
			score++;
			text.text = "Score: " + score;
		} 

	}

	void Awake()
	{
		DontDestroyOnLoad(this);
	}
}
