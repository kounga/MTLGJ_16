using UnityEngine;
using System.Collections;

public class TabActions : MonoBehaviour {

	private int selectedTab;
	public string[] actions;
	public GameObject newText;
	private GameObject[] textTab;
	// Use this for initialization
	void Start () {
		if(actions.Length != 0)
		{
			for (int i=0; i<actions.Length; i++) {
				Vector3 posText= new Vector3(transform.position.x,transform.position.y*i,transform.position.z);
				Instantiate(newText,posText,transform.rotation);
				newText.transform.parent = this.transform;
				TextMesh text = newText.GetComponent<TextMesh>();
				text.text = actions[i];
			}
			textTab = GameObject.FindGameObjectsWithTag("TextTabs");
		}
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyDown(KeyCode.DownArrow))
			selectedTab--;
		else if(Input.GetKeyDown(KeyCode.UpArrow))
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
			Debug.Log (textTab[selectedTab].GetComponent<TextMesh>().text);
			textTab[selectedTab].GetComponent<TextMesh>().color = Color.yellow;


		}
		if (Input.GetButton("Use")) {
			Debug.Log ("Use "+textTab[selectedTab].GetComponent<TextMesh>().text);
		}
		if (Input.GetButton("Cancel"))
			Debug.Log ("Annule");
	}
}
