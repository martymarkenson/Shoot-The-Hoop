using UnityEngine;
using System.Collections;

public class ScoreGoal : MonoBehaviour {
	public int value;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		scoreKeeper.IncrementScore (value);
	}
}
