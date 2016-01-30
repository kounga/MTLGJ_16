using UnityEngine;
using System.Collections;

public class ObjectChat : MonoBehaviour {
	[SerializeField]
	public GameObject buttonAction;
	public string[] actions;
	// Use this for initialization
	void Start () {
		buttonAction.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player"){
			buttonAction.SetActive(true);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player"){
			buttonAction.SetActive(false);
		}
	}
}
