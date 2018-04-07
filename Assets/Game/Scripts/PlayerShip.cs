using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerShip : MonoBehaviour {

	[Tooltip("In ms^-1")][SerializeField] float Speed = 10f;
	[Space(10)]
	[SerializeField] float positionPitchFactor = -12f;
	[SerializeField] float controlPitchfactor = -15f;
	[Space(10)]
	[SerializeField] float positionYawfactor = 12f;
	[SerializeField] float controlYawfactor = 15f;
	[Space(10)]
	[SerializeField] float controlRollfactor = 15f;


	float xThrow, yThrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HandleTranslation ();
		HandleRotation();
	}

	void HandleRotation ()
	{
		float pitch = transform.localPosition.y * positionPitchFactor + yThrow * controlPitchfactor;
		float yaw = transform.localPosition.x * positionYawfactor + xThrow * controlYawfactor;
		float roll = xThrow  * controlRollfactor;
		transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
	}
	void HandleTranslation ()
	{
		xThrow = CrossPlatformInputManager.GetAxis ("Horizontal");
		float xOffset = xThrow * Speed * Time.deltaTime;
		float rawNewXPos = Mathf.Clamp (transform.localPosition.x + xOffset, -2f, 2f);
		yThrow = CrossPlatformInputManager.GetAxis ("Vertical");
		float yOffset = yThrow * Speed * Time.deltaTime;
		float rawNewYPos = Mathf.Clamp (transform.localPosition.y + yOffset, -1.6f, 1.6f);
		transform.localPosition = new Vector3 (rawNewXPos, rawNewYPos, transform.localPosition.z);
	}
}
