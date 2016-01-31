using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	float playerSpeed = 0.07f;

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate () {

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

	void drinkGoodCoffee() {
		animator.SetTrigger ("coffeeGood");
	}

	void drinkBadCoffee() {
		animator.SetTrigger ("coffeeBad");
	}

	void eatGoodToast() {
		animator.SetTrigger ("toastGood");
	}

	void eatBadToast() {
		animator.SetTrigger ("toastBad");
	}

	void eatGoodCereal() {
		animator.SetTrigger ("cerealGood");
	}

	void eatBadCereal() {
		animator.SetTrigger ("cerealBad");
	}
}
