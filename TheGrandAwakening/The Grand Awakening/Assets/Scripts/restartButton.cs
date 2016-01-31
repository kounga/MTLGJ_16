using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour {

	public void ClickExit(){
		SceneManager.LoadScene ("KEVIN");
	}
}
