using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class typerAuto : MonoBehaviour {


	public string msg = "Replace";
	private Text textComp;
	public float startDelay = 2.0f;
	public float typeDelay = 0.001f;


	// Use this for initialization
	/*void Start () {
		StartCoroutine ("TypeIn");
	}*/
	

	void Awake () {
		textComp = GetComponent<Text> ();
	}

	//auto type text
	public IEnumerator TypeIn(){
		yield return new WaitForSeconds (startDelay);
		for (int i = 0; i < msg.Length; i++) {
			textComp.text = msg.Substring (0,i);
			yield return new WaitForSeconds (typeDelay);
		}
	}

	//auto delete text
	public IEnumerator TypeOff(){
		
		for (int i = msg.Length; i >=0 ; i--) {
			textComp.text = msg.Substring (0,i);
			yield return new WaitForSeconds (typeDelay);
		}
	}


}
