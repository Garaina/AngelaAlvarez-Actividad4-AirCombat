using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	

			if (Input.GetKey (KeyCode.UpArrow)) {
				this.transform.Translate (0.0f, 0.5f, 0.0f);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				this.transform.Translate (0.0f, -0.5f, 0.0f);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				this.transform.Translate (0.5f, 0.0f, 0.0f);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				this.transform.Translate (-0.5f, 0.0f, 0.0f);
			}


			if (Input.GetKeyDown (KeyCode.Space)) {	

				GameObject missile = GameObject.Instantiate (
					Resources.Load ("Prefab/Missil")as GameObject);
				missile.transform.SetParent (this.gameObject.transform);
				missile.transform.localPosition = new Vector3 (0, -7, 0);
				missile.transform.SetParent (null);

		}
	}
}
