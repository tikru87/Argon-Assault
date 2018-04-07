using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	private void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
	void Start () {
		Invoke("LoadStartMenu", 2f);
	}
	
	void LoadStartMenu()
	{
		SceneManager.LoadScene(1);
	}
}