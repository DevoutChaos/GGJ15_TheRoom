
using UnityEngine;
using System;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

//This is the script which causes the clown to track the player
 
public class ClownHead : Calamity {

	public GameObject cameraAncor;
 
	//Declarations
	GameObject player;
	public Vector3 playerPosition;
	public float turretSpeed;
 
    // Use this for initialization
    void Start () 
    {
		//sets the 'player' variable to the actual player
 		player = GameObject.FindGameObjectWithTag("Player");
    }
 
    // Update is called once per frame
    void Update () 
    {
		if (cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y <= 315  && cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 45)
		{
			this.gameObject.SetActive(true);
		}
		//Creates a stopwatch to check the time between the end of 
		//the last event and the start of the new one
		Stopwatch stopWatch = new Stopwatch();
		stopWatch.Start();
		//Gets the length of time passed
		TimeSpan ts = stopWatch.Elapsed;
		//After the set duration has passed stop the timer and call an event
		if(ts.Seconds >= 20)
		{
			stopWatch.Stop();
			this.gameObject.SetActive(false);
		}

		//Checks for the position of the player
		playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

		//Rotate clowns head to look at player.
		Vector3 relativePos = playerPosition - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos); 
        rotation.x=0;
        rotation.z=0;
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turretSpeed);
    }
}