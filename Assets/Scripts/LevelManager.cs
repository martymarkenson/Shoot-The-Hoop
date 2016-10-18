using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float timeTillNextLevel = 0.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (timeTillNextLevel > 0)
			timeTillNextLevel -= Time.deltaTime;
			{
			if (timeTillNextLevel < 0) {
				LoadNextLevel();
			}
		}
		Debug.Log ("Time till next level: " + timeTillNextLevel);
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

	public void LoadPreviousLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
	} 

	public float GetTime(){
		return timeTillNextLevel;
	}
}