using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float timer = 0.0f;
	public float timeLeft = 180.0f; //start at 180s
	public bool timeUPs = false;

	private float minutes;
	private float seconds;

	public Font guiFont;
	private GUIStyle guiStyle = new GUIStyle();
	private string text;

	private typerAuto typer;
	private Animator gameOverAnim;


	void Start(){
		timer = timeLeft;
	}

	void Awake(){
		typer = GetComponentInChildren<typerAuto> ();
		gameOverAnim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if ( (timer <= 0) && (!timeUPs) ) {
			Debug.Log (getSeconds ());
			timeUPs = true;
			gameOverAnim.SetBool ("fadeIn",true);
			typer.StartCoroutine ("TypeIn"); 

		}
	
	}

	//Display the score on the GUI
	void OnGUI () {
		GUI.skin.font = guiFont;
		guiStyle.fontSize = 20;
		//guiStyle.normal.textColor = Color.red;
		minutes = Mathf.FloorToInt(timer / 60.0f);
		seconds = Mathf.FloorToInt(timer % 60.0f);
		if(timer >= 0)
			text = string.Format("{0:00}:{1:00}", minutes.ToString("0"), seconds.ToString("00"));
		else
			text = "0:00";
		GUI.Label(new Rect(10, 5, 100, 20), "Time: " + text, guiStyle);

	}

	public int getSeconds(){
		return (int)timer;
	}

}
