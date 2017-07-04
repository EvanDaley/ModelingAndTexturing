using UnityEngine;
using System.Collections;

public class WaitUntilExample : MonoBehaviour
{
	public int frame;
	public int escapeTime;

	void Start()
	{
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		Debug.Log("Waiting forthe turtles to escape...");
		yield return new WaitUntil(() => frame >= escapeTime);
		Debug.Log("The turtle escaped!");
	}

	void Update()
	{
		if (frame <= escapeTime)
		{
			Debug.Log("Frame: " + frame);
			frame++;
		}
	}
}