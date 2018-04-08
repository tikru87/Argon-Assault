using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

	float destructionDelay;
	// Use this for initialization
	void Start () {
		destructionDelay = gameObject.GetComponentInChildren<ParticleSystem>().main.duration;
		Destroy(gameObject, destructionDelay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
