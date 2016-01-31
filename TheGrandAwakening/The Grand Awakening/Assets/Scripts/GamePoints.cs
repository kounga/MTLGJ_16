using UnityEngine;
using System.Collections;

public class GamePoints : MonoBehaviour {

	int totalPoints = 0;
	public float timeMultiplier = 2f;
	public Timer timer;

	private typerAuto typer;
	private Animator gameOverAnim;


	public void addPoints(int points) {
		totalPoints += points;
	}
	public float getPoints() {
		return timer.getSeconds () * timeMultiplier + totalPoints;
	}
}
