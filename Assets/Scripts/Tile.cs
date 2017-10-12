using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	// Public attributes
	public string type;
	//public float cover; // Might implement later

	// Private attributes
	private bool isHighlighted;
	//private Vector3 globalPosition; // Might not be necessary

	void Start()
	{
		
	}
	
	void Update()
	{
		CheckType();
	}

	public void CheckType()
	{
		if(type == "Barrier")
		{
			//gameObject.transform.localScale.y = .25f;
			gameObject.transform.localScale = new Vector3(2f, .25f, 2f);
		}
		else if(type == "Mountain")
		{
			//gameObject.transform.localScale.y = 2f;
			gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
		}
		else if(type == "Forest")
		{
			//gameObject.transform.localScale.y = 1.5f;
			gameObject.transform.localScale = new Vector3(2f, 1.5f, 2f);
		}
		else
		{
			//gameObject.transform.localScale.y = .5f;
			gameObject.transform.localScale = new Vector3(2f, .5f, 2f);
		}
	}

	void Highlight()
	{
		
	}
}
