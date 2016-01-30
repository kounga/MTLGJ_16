using UnityEngine;
using System.Collections;

public class TaskManager : MonoBehaviour {

	
	private int nbrTasks;
	private string[] Tasks = {"drinkCoffee","shitCoffee"};
	private string currentTask;
	[SerializeField]
	private PlayerMax player;
	// Use this for initialization
	void Start () {
		currentTask = Tasks[Random.Range(0,Tasks.Length-1)];
	}
	// Update is called once per frame
	void Update () {
		if(player.currentAction != null)
		{
			Debug.Log(player.currentAction +" "+ currentTask);
			if(player.currentAction == currentTask)
				Debug.Log("GoodJob");
			else
				Debug.Log("BOOH");
			player.currentAction = null;
		}
	}
	void addNewAction()
	{
		currentTask = Tasks[Random.Range(0,Tasks.Length-1)];
		
	}
}
