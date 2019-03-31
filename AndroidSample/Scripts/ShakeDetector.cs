
// Shake detector
// Plays an animation when the phone is shaked with enough force

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeDetector : MonoBehaviour {

	// Variable for storing the acceleration at any moment
	Vector3 accelerationDir;

	// Name of the animation to be played when phone is shaked
	public string shakeAnimation;

	// Assing to your live2d Model
    public GameObject Live2dModel;
	Animator anim;

	void Start () 
	{
		// Gets access to the animator controller of the live2d model
        anim = Live2dModel.GetComponent<Animator>();
	}
	

	void Update () 
	{
		accelerationDir = Input.acceleration;

		// If you shake the mobile device hard enough
		if (accelerationDir.sqrMagnitude >= 3f) 
		{
            anim.Play(shakeAnimation);
        }
        // Or if in computer, press space key
        if (Input.GetKeyDown("space"))
        {
        	anim.Play(shakeAnimation);
        }
	}
}