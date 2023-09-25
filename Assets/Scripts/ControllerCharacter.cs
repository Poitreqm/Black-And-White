using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerCharacter : MonoBehaviour {


	bool grounded;
	float move;
	public float jump = 5f;
	public float speed = 9f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump));
			GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, GetComponent<Rigidbody2D>().velocity.y);

	}
	void FixedUpdate()
	{
		move = Input.GetAxis("Horizontal");

	}

}

