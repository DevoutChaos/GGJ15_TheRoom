
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

//This should be attached to an empty GameObject
//The various "Calamity" items should be similarly attached.
//The GameObjects the Calamity objects are attached to, are used (drag and drop) to get implemented withing the GameObject for this class.
public class RndEventManager : MonoBehaviour 
{
	
	//Declarations
	public bool eventActive = true;
	public float eventWaitTime;
	public int minTime;
	public int maxTime;
	public List<Calamity> Events = new List<Calamity>();
	public int noOfResets;
	public float curTime;
	
	//Declares other classes for event calls

	//Initialisation
	void Start () 
	{
		//Prevents the update from auto running
		//eventActive = true;
		//Allows the min/max wait times to be changed
		//minTime = 30;
		//maxTime = 60;
		//Generates a random number between the min and max wait times
		System.Random rnd = new System.Random();
		eventWaitTime = rnd.Next(minTime, maxTime);
	}

	public void Reset()
	{
		noOfResets++;
		if (Events.Count == noOfResets) {
			this.gameObject.SetActive(false);
				}
		eventActive = false;
		System.Random rnd = new System.Random();
		eventWaitTime = rnd.Next(minTime, maxTime);
	}
	
	//Call Update once per frame
	void Update () 
	{
		//Checks that no event is running
		if(eventActive == false)
		{
			//After the set duration has passed stop the timer and call an event
			if(curTime >= eventWaitTime)
			{

				EventPicker();
			}
		}
	}

	public void FixedUpdate ()
	{
		if (eventActive == false) {
			curTime += 0.02f;
		}
	}

	public void EventPicker()
	{	
		eventActive = true;
		Debug.Log("hit condition");

		curTime = 0.0f;

		//Picks a random event via index
		System.Random rand = new System.Random();
		int indexToRemove = rand.Next(0, Events.Count);
		
		//Calls the given event based on the index of the event

		Calamity evnt = Events[indexToRemove];
		evnt.proc ();
				
		Debug.Log ("end of event");
		//Removes the event
		//Events.RemoveAt(indexToRemove);
	}
}
 
