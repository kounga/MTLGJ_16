using UnityEngine;
using System.Collections;

public class TabActions : MonoBehaviour {

	private int selectedTab;
	public string[] actions;
	public GameObject newText;
	private GameObject[] textTab;
	private PlayerMax player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMax>();
		if(actions.Length != 0)
		{
			for (int i=0; i<actions.Length; i++) {
				Vector3 posText= new Vector3(transform.position.x+1,transform.position.y+1+(0.08f*i),transform.position.z);
				GameObject pom = (Instantiate(newText,posText,transform.rotation)as GameObject);
				pom.transform.parent = transform;
				TextMesh text = newText.transform.GetChild(0).GetComponent<TextMesh>();
				text.text = actions[i];
			}
			textTab = GameObject.FindGameObjectsWithTag("TextTabs");
		}
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetButtonDown("Down"))
			selectedTab--;
		else if(Input.GetButtonDown("Up"))
			selectedTab--;

		if (selectedTab < 0)
			selectedTab = actions.Length-1;
		if (selectedTab >= actions.Length)
			selectedTab = 0;
		if (textTab.Length != 0) 
		{
			for (int i=0; i<textTab.Length; i++){
				textTab[i].GetComponent<TextMesh>().color = Color.white;
			}
			textTab[selectedTab].GetComponent<TextMesh>().color = Color.yellow;


		}
		if (Input.GetButton("Use") && !player.spaceIsDown) {
			player.currentAction = textTab[selectedTab].GetComponent<TextMesh>().text;
			Object.Destroy(this.gameObject);
		}
		if (Input.GetButton("Cancel"))
			Debug.Log ("Annule");
	}
}
