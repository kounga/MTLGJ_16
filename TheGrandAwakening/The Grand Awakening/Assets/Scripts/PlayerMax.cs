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
	public bool spaceIsDown;
	private float playerSpeed = 0.07f;
	public Animator animator;
	public Animation anim;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}

	void FixedUpdate () {

		if (tabsGestion == null) {
			if(targetObject != null)
				if ((targetObject.buttonAction.activeSelf && Input.GetButtonDown("Use")) && !spaceIsDown)
				{
					spaceIsDown = true;
					Instantiate(tabActionPrefab,transform.position,transform.rotation);
					tabsGestion = GameObject.FindGameObjectWithTag("Tabs").GetComponent<TabActions>();
					tabsGestion.actions = actions;
				}
			//Mouvement
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

			//Animation
			if (Input.GetButtonDown ("Left")) {
				animator.SetBool ("walking_right", true);
				transform.localScale = new Vector3 (-2f, 2f, 0f);
			}
			if (Input.GetButtonUp ("Left")) {
				animator.SetBool ("walking_right", false);
			}
			if (Input.GetButtonDown ("Right")) {
				animator.SetBool ("walking_right", true);
				transform.localScale = new Vector3 (2f, 2f, 2f);
			}
			if (Input.GetButtonUp ("Right")) {
				animator.SetBool ("walking_right", false);
			}
			if (Input.GetButtonDown ("Up")) {
				animator.SetBool ("walking_up", true);
			}
			if (Input.GetButtonUp ("Up")) {
				animator.SetBool ("walking_up", false);
			}
			if (Input.GetButtonDown ("Down")) {
				animator.SetBool ("walking_down", true);
			}
			if (Input.GetButtonUp ("Down")) {
				animator.SetBool ("walking_down", false);
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
