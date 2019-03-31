
// DragMouseMove
// Simply makes an object follow the mouse or your finger if its clicking or touching the screen

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouseMove : MonoBehaviour {

    private Vector3 mousePosition;
    //private Vector3 touchPosition;

	void Update () {
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                transform.position = touchPosition;
        }*/
        // If touch or click, move the object where action is going on
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
        // Else move the object to the centerof the screen
        else {
            transform.position = new Vector3(0f,0f,0f);
        }
    }
}
