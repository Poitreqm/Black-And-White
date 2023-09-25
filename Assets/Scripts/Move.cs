using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb;
	public float speed = 12f;
	public float force = 9f;
	public static int score = 0;

	public bool isGrounded = false;

	public GameObject panel;

	public AudioSource audio;


	// Use this for initialization
	void Start()
	{
		audio.Play();



		panel.SetActive(false);
		Time.timeScale = 1f;
		score = 0;
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		



		Jump();
		rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);


	}

	void FixedUpdate()
	{

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Rhombus" && gameObject.tag == "BlackPlayer")
		{
			Destroy(collision.gameObject);
			score++;


		}

		if (collision.gameObject.tag == "Rhombus" && gameObject.tag == "WhitePlayer")
		{
			Destroy(collision.gameObject);
			score++;

		}
		

		if(collision.gameObject.tag == "Enemy")
		{
			YourAreDead();
		}

		if(collision.gameObject.tag == "Door")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		if ((collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Wall") && isGrounded == false)
		{
			isGrounded = true;
		}
	}


	void Jump()
	{

		if (Input.GetKeyDown(KeyCode.Space) && gameObject.tag == "BlackPlayer" && isGrounded)
		{

			rb.AddForce(new Vector2(0f, force));
			isGrounded = false;
			rb.velocity = new Vector2(0f, 0f);
		}




		if (Input.GetKeyDown(KeyCode.Space) && gameObject.tag == "WhitePlayer" && isGrounded)
		{
			//rb.AddForce(Vector2.down * (force - rb.velocity.y), ForceMode2D.Impulse);
			//isGrounded = false;
			rb.AddForce(new Vector2(0f, -force));
			isGrounded = false;
			rb.velocity = new Vector2(0f, 0f);
		}
	}

	void YourAreDead()
	{

		panel.SetActive(true);
		audio.Stop();
		GetComponent<AudioSource>().Play();
		Time.timeScale = 0f;

	}

}
