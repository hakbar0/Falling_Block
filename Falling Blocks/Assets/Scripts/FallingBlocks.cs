using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlocks : MonoBehaviour {

	public GameObject FallingBlock;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnBlock", 2.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void SpawnBlock(){
		GameObject instance = Instantiate (FallingBlock);
		instance.transform.position = new Vector3(Random.Range(-7.5f, 7.5f), 5.8f, 0f);
	}
}
