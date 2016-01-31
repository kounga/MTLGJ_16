using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class typerAuto : MonoBehaviour {


	private string gameOverMsg = "GameOver! Time's up! \n \n Score : ";
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
		gameOverMsg += score.ToString ();
		gameOverMsg += " ";
		yield return new WaitForSeconds (startDelay);
		for (int i = 0; i < gameOverMsg.Length; i++) {
			textComp.text = gameOverMsg.Substring (0,i);
			yield return new WaitForSeconds (typeDelay);
		}
	}

	/*//auto delete text
	public IEnumerator TypeOff(){
		
		for (int i = msg.Length; i >=0 ; i--) {
			textComp.text = msg.Substring (0,i);
			yield return new WaitForSeconds (typeDelay);
		}
	}*/


}
