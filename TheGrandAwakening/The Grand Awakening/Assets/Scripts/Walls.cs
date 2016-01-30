using UnityEngine;
using System.Collections;

public class Walls : MonoBehaviour {

	public GameObject player;
	Color color;


	// Use this for initialization
	void Start () {
		color = GetComponent<Renderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.position.z + " ## " + player.transform.position.z);
		GetComponent<Renderer> ().material.color = color;
		if (transform.position.z < player.transform.position.z) {
			color.a = 0.2f;
		}
		else {
			color.a = 1f;
		}
	}
}
