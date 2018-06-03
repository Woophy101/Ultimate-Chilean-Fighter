using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {


	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;
	public AudioSource audiosource;
	float volume;

	void Start(){

		if (PauseMenuUI != null) {
			PauseMenuUI.SetActive (false);
		}
		if  (audiosource != null){
			volume = audiosource.volume;
		}
	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}


	}
		
	public void ToScene(string scene){
		SceneManager.LoadScene (scene);
	}

	public void QuitGame (){
		Application.Quit ();
	}

	public void ResumeGame(){
		
	}


	void Resume(){
		PauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		audiosource.volume = volume;
	}

	void Pause (){
		PauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		audiosource.volume = volume * 0.5f;
	}
}
