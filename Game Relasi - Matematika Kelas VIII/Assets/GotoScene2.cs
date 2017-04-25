using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GotoScene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ToHomePage(){
		SceneManager.LoadScene ("_SCENE_0");
	}

	public void ToGame(){
		SceneManager.LoadScene ("_SCENE_1");
	}
		

	public void ToWin(){
		SceneManager.LoadScene ("_SCENE_2");
	}
}
