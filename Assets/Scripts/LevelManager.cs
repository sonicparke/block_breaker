using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		SceneManager.LoadScene(name);
		this.GetComponent<AudioSource>().Play();
	}

	public void QuitRequest (string name)
	{
		Debug.Log("Quit  Yo!");
		Application.Quit();
	}

	public void LoadNextLevel ()
	{
		int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(nextSceneIndex);
//		this.GetComponent<AudioSource>().Play();
	}

	public void BrickDestroyed () {
//		this.GetComponent<AudioSource>().Play();
		if(Brick.breakableCount <= 0){
			LoadNextLevel();
		}
	}
}
