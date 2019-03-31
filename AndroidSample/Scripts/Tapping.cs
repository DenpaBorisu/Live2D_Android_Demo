
// Tapping
// This Script is used to trigger animations when pointed objects are clicked or touched

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapping : MonoBehaviour
{
	[System.Serializable]
	public class AnimationList
	{
		public string animationGroup;
    	public string[] animations;
 	}
 	// This animation list is an array of animation groups,
 	// on the inspector make a new list for everygroup of animations you want.
 	// Make sure the name of everygroup is the same as the object that would be clicked or touched.
 	// *names of the animations
 	public AnimationList[] animationList;

	// Assing to your live2d Model
	public GameObject Live2dModel;
	Animator anim;
    
    void Start()
    {
    	// Gets access to the animator controller of the live2d model
        anim = Live2dModel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
    	// If mouse click or touch
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // If the mouse or touch is on something that has raycast
            if (Physics.Raycast(ray, out hit))
            {
            	// Search on what is the click or touch
            	foreach(AnimationList animlist in animationList)
            	{
            		if (hit.transform.name == animlist.animationGroup)
                	{
                		// Then play a random animation from that group
                    	var toplay = animlist.animations[Random.Range(0,animlist.animations.Length)];
    					anim.Play(toplay);
                	}
            	} 
            }
        }

    }
}
