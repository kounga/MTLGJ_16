using UnityEngine;
using System.Collections;

public class PlayerMax : MonoBehaviour {

	ObjectChat targetObject;
	[SerializeField]
	public string[] actions;
	[SerializeField]
	public GameObject tabActionPrefab;
	private TabActions tabsGestion;
	// Use this for initialization
	void Start () {
		
	}

	void FixedUpdate () {

		if (targetObject != null && tabsGestion == null) {
			if (targetObject.buttonAction.activeSelf && Input.GetButton("Use"))
			{
				Instantiate(tabActionPrefab,transform.position,transform.rotation);
				tabsGestion = GameObject.FindGameObjectWithTag("Tabs").GetComponent<TabActions>();
				tabsGestion.actions = actions;
			}
		}

	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Object"){
			targetObject = other.GetComponent<ObjectChat>();
			actions = targetObject.actions;
		}
	}

}
