using UnityEngine;
using System.Collections;

public class PlayerMax : MonoBehaviour {

	ObjectChat targetObject;
	[SerializeField]
	public string[] actions;
	public string currentAction = null;
	[SerializeField]
	public GameObject tabActionPrefab;
	private TabActions tabsGestion;
	private bool spaceIsDown;
	// Use this for initialization
	void Start () {
	}

	void FixedUpdate () {

		if (targetObject != null && tabsGestion == null) {
			if ((targetObject.buttonAction.activeSelf && Input.GetButtonDown("Use")) && !spaceIsDown)
			{
				spaceIsDown = true;
				Instantiate(tabActionPrefab,transform.position,transform.rotation);
				tabsGestion = GameObject.FindGameObjectWithTag("Tabs").GetComponent<TabActions>();
				tabsGestion.actions = actions;
			}
		}
		if(Input.GetButtonUp("Use"))
			spaceIsDown = false;

	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Object"){
			targetObject = other.GetComponent<ObjectChat>();
			actions = targetObject.actions;
		}
	}

}
