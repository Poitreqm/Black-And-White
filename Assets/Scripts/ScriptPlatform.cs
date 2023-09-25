using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlatform : MonoBehaviour {

	//public  float normal = 1f;
	//public  float increase = 1.2f; // 10%
	public float speedChangeSize = 0.01f;


	public Vector3[] scales = new Vector3[2]
		{
		new Vector3(1.2f, 1.0f, 1.0f),
		new Vector3(1f, 1.0f, 1.0f)
		};

	void Start()
	{
		StartCoroutine(ChangeScale());
	}

	IEnumerator ChangeScale()
	{
		int index = 0;
		int counter = 0;

		while (counter < 1)
		{
			transform.localScale = Vector3.Lerp(transform.localScale, scales[index], Time.deltaTime + speedChangeSize);

			if (Vector3.Distance(transform.localScale, scales[index]) < 0.001f)
			{
				if (++index > 1)
				{
					index = 0;
					counter++;
				}
			}

			yield return null;

		}
	}






	//void Change()
	//{


	//	if ( transform.localScale.x >= 1.1f)
	//	{
	//		transform.localScale = new Vector3(Mathf.PingPong(Time.time * speedChangeSize, normal - increase) + normal, 1f, 1f);

	//	}
	//	else
	//	{
	//		transform.localScale += new Vector3(0.01F, 0, 0);
	//	}
	//}

}
