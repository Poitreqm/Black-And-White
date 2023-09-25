using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {

	public Text text;

	public GameObject whitetDoor;
	public GameObject blackDoor;

	// Use this for initialization
	void Start () {
		whitetDoor.SetActive(false);
		blackDoor.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene().name == "level1" && Move.score >= 3)
		{
			whitetDoor.SetActive(true);
			blackDoor.SetActive(true);

		}

		if (SceneManager.GetActiveScene().name == "level2" && Move.score >= 3)
		{
			whitetDoor.SetActive(true);
			blackDoor.SetActive(true);
		}

		if (SceneManager.GetActiveScene().name == "level3" && Move.score >= 3)
		{
			whitetDoor.SetActive(true);
			blackDoor.SetActive(true);
		}

		if (SceneManager.GetActiveScene().name == "level1")
			{
			text.text = Move.score.ToString() + "/3";
		}

		if (SceneManager.GetActiveScene().name == "level2")
		{
			text.text = Move.score.ToString() + "/3";
		}

		if (SceneManager.GetActiveScene().name == "level3")
		{
			text.text = Move.score.ToString() + "/3";
		}
	}
}
