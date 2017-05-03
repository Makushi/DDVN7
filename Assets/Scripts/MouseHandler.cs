using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour {

	private float horinzontalSpeed = 2.0F;
	private float verticalSpeed = 2.0F;

	void Update()
	{
		Vector3 mousePos = Input.mousePosition;
		transform.LookAt(Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, Screen.height - mousePos.y, 10.0f)));
	}		
		
	void OnMouseDown()
	{
		Animator anim = transform.GetComponent<Animator> ();
	}
}
