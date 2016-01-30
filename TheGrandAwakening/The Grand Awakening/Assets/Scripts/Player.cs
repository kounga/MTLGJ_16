using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	float playerSpeed = 0.1f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton ("Left")) {
			transform.Translate (new Vector3 (-playerSpeed, 0f, 0f));
		}
		if (Input.GetButton ("Right")) {
			transform.Translate (new Vector3 (playerSpeed, 0f, 0f));
		}
		if (Input.GetButton ("Up")) {
			transform.Translate (new Vector3 (0f, 0f, playerSpeed));
		}
		if (Input.GetButton ("Down")) {
			transform.Translate (new Vector3 (0f, 0f, -playerSpeed));
		}
		if (Input.GetButton ("Spin")) {
			transform.Rotate (new Vector3 (0f, 10f, 0f));
		}
	}
}
