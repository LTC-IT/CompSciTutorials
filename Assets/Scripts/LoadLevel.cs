using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	public void LoadScene (int level) {
		
		SceneManager.LoadScene(level);
	}

	public void LoadSceneName (string sceneName) {
		Debug.Log("sceneName to load: " + sceneName);
		SceneManager.LoadScene(sceneName);
	}

}
