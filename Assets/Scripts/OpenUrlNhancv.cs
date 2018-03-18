using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrlNhancv : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown("escape"))
			Application.Quit();

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
					if (hit.collider.gameObject.name == "NhancvSite") {
						Application.OpenURL ("https://nhancv.github.io");
					}

				}
			}
		}
	}

}
