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
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}
	private void OnTriggerEnter (Collider other){
			if (other.gameObject.tag == "Object"){
				targetObject = other.GetComponent<ObjectChat>();
				if(targetObject.actions.Length !=0){
					actions = targetObject.actions;
				}
				
			}
		}
	void FixedUpdate () {

		if (tabsGestion == null) {
			if(targetObject != null && targetObject.actions.Length !=0)
				if ((targetObject.buttonAction.activeSelf && Input.GetButtonDown("Use")) && !spaceIsDown)
				{
					spaceIsDown = true;
					GameObject tab = (Instantiate(tabActionPrefab,transform.position,transform.rotation)as GameObject);
					tab.transform.parent = mainCamera.transform;
					tabsGestion = GameObject.FindGameObjectWithTag("Tabs").GetComponent<TabActions>();
					tabsGestion.actions = targetObject.actions;
					tabsGestion.buildTabs();
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
				transform.localScale = new Vector3 (-2f, 2f, 2f);
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
	public void drinkGoodCoffee() {
		animator.SetTrigger ("coffeeGood");
	}

	public void drinkBadCoffee() {
		Debug.Log("fff");
		animator.SetTrigger ("coffeeBad");
	}

	public void eatGoodToast() {
		animator.SetTrigger ("toastGood");
	}

	public void eatBadToast() {
		Debug.Log("fffsss");
		animator.SetTrigger ("toastBad");
	}

	public void eatGoodCereal() {
		animator.SetTrigger ("cerealGood");
	}

	public void eatBadCereal() {
		animator.SetTrigger ("cerealBad");
	}
	public void ballCatBad() {
		animator.SetTrigger ("ballCatBad");
	}

	public void ballCatGood() {
		animator.SetTrigger ("ballCatGood");
	}

	public void petCatGood() {
		animator.SetTrigger ("catGood");
	}

	public void petCatBad() {
		animator.SetTrigger ("catBad");
	}

	public void lookAtWindowGood() {
		animator.SetTrigger ("windowGood");
	}

	public void lookAtWindowBad() {
		animator.SetTrigger ("windowBad");
	}

	public void smellGood() {
		animator.SetTrigger ("smellGood");
	}

	public void smellBad() {
		animator.SetTrigger ("smellBad");
	}

	public void doYogaGood() {
		animator.SetTrigger ("yogaGood");
	}

	public void doYogaBad() {
		animator.SetTrigger ("yogaBad");
	}
	public void laptopGood() {
		animator.SetTrigger ("laptopGood");
	}
	public void laptopBad() {
		animator.SetTrigger ("laptopBad");
	}
	public void showerGood() {
		animator.SetTrigger ("showerGood");
	}
	public void showerBad() {
		animator.SetTrigger ("showerBad");
	}
}
