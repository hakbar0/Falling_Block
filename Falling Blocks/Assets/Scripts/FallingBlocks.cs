using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour {

	public GameObject FallingBlock;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnBlock", 2.0f, 0.7f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void SpawnBlock(){
		GameObject instance = Instantiate (FallingBlock);
		instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 8.0f, 0f);
	}
}
