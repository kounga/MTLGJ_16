using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class txtController : MonoBehaviour {

	public Renderer rend;
	private string text;

	void Start() {
		rend = GetComponent<Renderer>();
	}

	//change 3Dtext color on mouse over
	void OnMouseEnter() {
		rend.material.color = Color.red;
	}


	void OnMouseExit() {
		rend.material.color = Color.white;
	}

	void OnMouseDown() {

		if( gameObject.tag == "start" )			
			SceneManager.LoadScene ("main-max"); //application.loadScene is obsolete
		
		if( gameObject.tag == "quit" )
			Application.Quit();
			
	}


}
