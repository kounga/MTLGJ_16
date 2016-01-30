using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float timer = 0.0f;
	public float timeLeft = 180.0f; //start at 180s
	bool timeUPs = false;

	private float minutes;
	private float seconds;

	public Font guiFont;
	private GUIStyle guiStyle = new GUIStyle();


	void Start(){
		timer = timeLeft;
	}

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
			timeUPs = true;
			//TODO

			//calculate score
			//end game
			//load scene "game over" and show score
			// ???
			//profit
		}
	
	}

	//Display the time on the GUI
	void OnGUI () {
		GUI.skin.font = guiFont;
		guiStyle.fontSize = 20;
		//guiStyle.normal.textColor = Color.red;
		minutes = Mathf.FloorToInt(timer / 60.0f);
		seconds = Mathf.FloorToInt(timer % 60.0f);
		string text = string.Format("{0:00}:{1:00}", minutes.ToString("0"), seconds.ToString("00"));
		GUI.Label(new Rect(10, 5, 100, 20), "Time: " + text, guiStyle);

	}

	public int getSeconds(){
		return (int)timeLeft;
	}
}
