﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	
	public void FirstScene (){
		SceneManager.LoadScene("Main");
	}

	public void EndScene (){
		SceneManager.LoadScene("End");
	}
		
}
