using UnityEngine;
using System.Collections;

public class TaskManager : MonoBehaviour {

	
	private int nbrTasks;
	private string currentTask;
	private GameObject currentPictogram;
	private int currentTaskId;
	[SerializeField]
	private PlayerMax player;
	[SerializeField]
	private GameObject mainCameraCanvas;
	[SerializeField]
	private GameObject spritePictogram;
	[SerializeField]
	private string[] tasksArray;
	[SerializeField]
	private Sprite[] spriteArray;
	// Use this for initialization
	void Start () {
		
		reshuffle(tasksArray,spriteArray);
		addNewAction();
	}
	// Update is called once per frame
	void Update () {
		Debug.Log(player.currentAction +" "+ currentTask);
		if(player.currentAction != null)
		{
			
			if(player.currentAction == currentTask)
			{
				switch(currentTask) 
				{
					case "Drink capucino":
					case "Drink coffee":
						player.drinkGoodCoffee();
						break;
					case "Eat cereal":
						player.eatGoodCereal();
						break;
					case "Eat toast":
						player.eatGoodToast();
						break;
				}
				Object.Destroy(currentPictogram);
				currentTaskId++;
				addNewAction();
				
			}
			else{
				switch(player.currentAction) 
				{
					case "Drink capucino":
					case "Drink coffee":
						player.drinkBadCoffee();
						break;
					case "Eat cereal":
						player.eatBadCereal();
						break;
					case "Eat toast":
					case "Eat bagel":
						player.eatBadToast();
						break;
				}
			}
			player.currentAction = null;
		}
	}
	void addNewAction()
	{
		if(currentTaskId == tasksArray.Length || currentTaskId == nbrTasks)
		{
			currentTaskId=0;
			
		}
		currentTask = tasksArray[currentTaskId];
		currentPictogram = (Instantiate(spritePictogram)as GameObject);
		currentPictogram.GetComponent<SpriteRenderer>().sprite = spriteArray[currentTaskId];
		currentPictogram.transform.position = new Vector3(mainCameraCanvas.transform.position.x,mainCameraCanvas.transform.position.y+0.1f,mainCameraCanvas.transform.position.z+0.8f);
		currentPictogram.transform.parent = mainCameraCanvas.transform;

	}
	void reshuffle(string[] texts, Sprite[] spriteArray)
    {
        for (int t = 0; t < texts.Length; t++ )
        {
            string tmp = texts[t];
			Sprite smp = spriteArray[t];
            int r = Random.Range(t, texts.Length);
            texts[t] = texts[r];
            texts[r] = tmp;
			spriteArray[t] = spriteArray[r];
            spriteArray[r] = smp;
        }
    }
}
