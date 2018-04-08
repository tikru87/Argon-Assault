using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Enemy : MonoBehaviour {

	[SerializeField] GameObject deathFX;
	[SerializeField] Transform parent;
	[SerializeField] ScoreBoard scoreBoard;
	[SerializeField] int scorePerHit = 12;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnParticleCollision (GameObject other)
	{
		GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
		fx.transform.parent = parent;
		Destroy(gameObject);
		scoreBoard.ScoreHit(scorePerHit);
	}
}
