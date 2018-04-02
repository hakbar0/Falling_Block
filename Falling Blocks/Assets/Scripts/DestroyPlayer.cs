using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	void OnTriggerEnter(Collider collision){
		LevelManager levelManager = FindObjectOfType<LevelManager> ();
		levelManager.EndScene ();
		Destroy (gameObject);
	
	}
}
