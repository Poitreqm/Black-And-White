using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlatform : MonoBehaviour {

	public Vector3 newScale = new Vector3(1.5f, 1f, 1f);
	public float speedChangeSize = 1f;

	public float rotationZ = 0f;

	//public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		//StartCoroutine(SlowScale());
	}
	
	// Update is called once per frame
	void Update () {
		Change();
		Rotation();
	}


	void Change()
	{
		transform.localScale = Vector3.Lerp(transform.localScale, newScale, Time.deltaTime + speedChangeSize);
		
	}


	void Rotation()
	{
		if (Time.timeScale == 1f)
		{
			transform.Rotate(0, 0, rotationZ);
		}
		else
		{

		}
	}

	//IEnumerator SlowScale()
	//{
	//	for (float q = 1f; q <= 1.5f; q += 0.1f)
	//	{
	//		transform.localScale = new Vector3(q, 1f, 1f);
	//		yield return new WaitForSeconds(speed);
	//	}

	//}
}
