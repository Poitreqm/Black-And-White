using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour {

	public Sprite[] score;
	public Image scoreBar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ScoreUpdate(int index)
	{
		scoreBar.sprite = score[index];
	}
}
