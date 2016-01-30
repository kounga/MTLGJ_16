using UnityEngine;
using System.Collections;

public class TaskManager : MonoBehaviour {

	
	private int nbrTasks;
	private string[] Tasks = {"drinkCoffee","shitCoffee"};
	private string currentTask;
	private GameObject currentPictogram;
	private int currentTaskId;
	[SerializeField]
	private PlayerMax player;
	[SerializeField]
	private Camera mainCamera;
	[SerializeField]
	private GameObject spritePictogram;
	// Use this for initialization
	void Start () {
		
		reshuffle(Tasks);
		addNewAction();
	}
	// Update is called once per frame
	void Update () {
		Debug.Log(player.currentAction +" "+ currentTask);
		if(player.currentAction != null)
		{
			
			if(player.currentAction == currentTask)
			{
				Debug.Log("GoodJob");
				Object.Destroy(currentPictogram);
				currentTaskId++;
				addNewAction();
				
			}
			else
				Debug.Log("BOOH");
			player.currentAction = null;
		}
	}
	void addNewAction()
	{
		if(currentTaskId == Tasks.Length || currentTaskId == nbrTasks)
		{
			currentTaskId=0;
			
		}
		currentTask = Tasks[currentTaskId];
		currentPictogram = (Instantiate(spritePictogram)as GameObject);
		currentPictogram.transform.parent = mainCamera.transform;
		currentPictogram.transform.position = new Vector3(-2.01f,1.428f,2.068f);
	}
	void reshuffle(string[] texts)
    {
        for (int t = 0; t < texts.Length; t++ )
        {
            string tmp = texts[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
        }
    }
}
