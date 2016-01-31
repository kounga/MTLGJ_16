using UnityEngine;
using System.Collections;

public class GamePoints : MonoBehaviour {

	int totalPoints = 0;
	public float timeMultiplier = 2f;
	public Timer timer;

	private typerAuto typer;
	private Animator gameOverAnim;

	public Font guiFont;
	private GUIStyle guiStyle = new GUIStyle();
	private float score;


	public void addPoints(int points) {
		totalPoints += points;
	}
	public float getPoints() {
		return timer.getSeconds () * timeMultiplier + totalPoints;
	}

	public void Update(){
		score = totalPoints;
	}

	//display the score on the gui
	void OnGUI () {
		GUI.skin.font = guiFont;
		guiStyle.fontSize = 20;

		GUI.Label(new Rect(135, 5, 100, 20), "Score: "+ score.ToString(), guiStyle);

	}
}
