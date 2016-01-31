using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class typerAuto : MonoBehaviour {


	private string gameOverMsg = "GameOver! Time's up! \n \n You only scored : ";
	private string winMsg = "GameOver! Time's up! \n \n Nice! You scored : ";
	private string msgToDisplay = "placeholder";
	private Text textComp;
	public float startDelay = 2.0f;
	public float typeDelay = 0.05f;
	public GamePoints points; //reference sur le gameObject score
	private float score;


	void Awake () {
		textComp = GetComponent<Text> ();


	}

	//auto type text
	public IEnumerator TypeIn(){
		score = points.getPoints ();
		if (score > 40.0)
			msgToDisplay = winMsg;
		else
			msgToDisplay = gameOverMsg;
			
		msgToDisplay += score.ToString ();
		msgToDisplay += " ";
		yield return new WaitForSeconds (startDelay);
		for (int i = 0; i < msgToDisplay.Length; i++) {
			textComp.text = msgToDisplay.Substring (0,i);
			yield return new WaitForSeconds (typeDelay);
		}
	}




}
