using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrlBss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		TapSelect(); 
	}	

	void TapSelect() 
	{
		foreach (Touch touch in Input.touches) 
		{
			if (touch.phase == TouchPhase.Began) 
			{
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
				RaycastHit hit;
				if (Physics.Raycast (ray, out hit)) 
				{
//					Debug.Log(hit.collider.gameObject.name);
					if (hit.collider.gameObject.name == "VideoWall") {
						Application.OpenURL ("https://beesightsoft.com");
					}

				}
			}
		}
	}
}
