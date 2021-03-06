using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		// don't render trigger just has render for editor purpose
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	
	void OnTriggerEnter(Collider other)
	{
		
		// if a platform object is colliding with the endlevel entity
		if(other.gameObject.tag == "Platform")
		{
			// do nothing
		}
		// otherwise it may be the player so trigger level code
		else
		{
			print("triggered");
			
			// if we're not on the last level
			if(Application.loadedLevel < Application.levelCount - 1)
			{
				// then load the next one
				Application.LoadLevel(Application.loadedLevel + 1);
			}
			// otherwise go back to the main menu (will change later for endgame state
			else
			{
				Application.LoadLevel(0);
					
			}
		}
	}
}
