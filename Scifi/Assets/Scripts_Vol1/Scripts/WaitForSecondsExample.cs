using UnityEngine;
using System.Collections;

public class WaitForSecondsExample : MonoBehaviour
{
	void Start()
	{
		StartCoroutine(ReleaseTheTurtles ());
	}

	IEnumerator ReleaseTheTurtles()
	{
		print ("Waiting for the turtles...");
		yield return new WaitForSeconds (1);
		print ("The turtles have been released...");
		yield return new WaitForSeconds (1);
		print ("They are eating the children");
	}
}