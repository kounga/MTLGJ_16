using UnityEngine;
using System.Collections.Generic;
using System.IO;

public static class Highscores {

	public static void registerScore(string name, int score) {
		StreamWriter streamWriter = new StreamWriter ("highscores.txt");
		string scoreString = name + "|" + score;
		streamWriter.WriteLine (scoreString);
		streamWriter.Close ();
	}

	public static int getHighScore() {
		string[] lines = File.ReadAllLines ("highscores.txt");
		string[] secondSplit;
		int highest = 0;
		foreach (string line in lines) {
			secondSplit = line.Split ('|');
			if (System.Int32.Parse(secondSplit [1]) > highest) {
				highest = System.Int32.Parse(secondSplit [1]);
			}
		}
		return highest;
	}

	public static string getHighScoreName ()
	{
		string[] lines = File.ReadAllLines ("highscores.txt");
		string[] secondSplit;
		int highest = 0;
		string name = "";
		foreach (string line in lines) {
			secondSplit = line.Split ('|');
			if (System.Int32.Parse(secondSplit [1]) > highest) {
				highest = System.Int32.Parse(secondSplit [1]);
				name = secondSplit [0];
			}
		}
		return name;
	}
}
