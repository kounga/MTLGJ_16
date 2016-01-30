using UnityEngine;
using System;

public class ObjectChat : MonoBehaviour {
	
	public GameObject[] buttonAction;
	public string[] actions = {"", "", ""};
	// Use this for initialization
	void Start () {
		foreach (GameObject gameObject in buttonAction) {
			gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		foreach (GameObject button in buttonAction) {
			if (other.gameObject.tag == "Player" && actions[Array.IndexOf(buttonAction, button)] != ""){
				button.SetActive (true);
			}
		}
	}
	void OnTriggerExit(Collider other){
		foreach (GameObject button in buttonAction ) {
			if (other.gameObject.tag == "Player") {
				button.SetActive (false);
			}
		}
	}
}