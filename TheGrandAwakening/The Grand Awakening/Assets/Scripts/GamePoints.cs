using UnityEngine;
using System.Collections;

public class GamePoints : MonoBehaviour {

	int totalPoints = 0;
	public float timeMultiplier = 2f;
	Timer timer;

	void addPoints(int points) {
		totalPoints += points;
	}

	void getPoints() {
		return timer.getSeconds () * timeMultiplier + totalPoints;
	}
}
