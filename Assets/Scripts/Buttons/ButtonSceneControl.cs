using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneControl : MonoBehaviour {

	public int scene;

	void SceneController (){
		SceneManager.LoadScene (scene);
	}
}
