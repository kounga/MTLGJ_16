using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private float timer = 0.0f;
	public float timeLeft = 120.0f; //start at 120

	public float minutes;
	public float seconds;

	void Start(){
		timer = timeLeft;
	}

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
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
		minutes = Mathf.FloorToInt(timer / 60.0f);
		seconds = Mathf.FloorToInt(timer % 60.0f);
		string text = string.Format("{0:00}:{1:00}", minutes.ToString("0"), seconds.ToString("0"));
		GUI.Label(new Rect(10, 110, 100, 20), "Time: " + text);

	}

	public void getSeconds(){
		return (int)timeLeft;
	}
}
