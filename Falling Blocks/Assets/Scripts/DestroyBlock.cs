using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour {


	void OnTriggerEnter(Collider collision){
		Destroy (gameObject, 2);
	}

}
