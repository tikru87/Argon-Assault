using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

	Text scoreDisplay;
	int score;

	// Use this for initialization
	void Start () {
	scoreDisplay = GetComponent<Text>();
	scoreDisplay.text = score.ToString();
	}

	public void ScoreHit (int scorePerHit)
	{
		score = score + scorePerHit;
		scoreDisplay.text = score.ToString();
	}
}
