
using UnityEngine;
using System;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

public class CatAppear : Calamity {

	public GameObject cameraAncor;
	public RndEventManager calamityManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y <= 315  && cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 45)
		{
			this.gameObject.SetActive(true);
		}

		if (this.gameObject.activeInHierarchy)
		{
			if (cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 315  && cameraAncor.GetComponent<Transform>().rotation.eulerAngles.y <= 45)
			{
				if(Input.GetButtonDown("A"))
				{
					//Do something
					calamityManager.eventActive = false;
				}
				if(Input.GetButtonDown("B"))
				{
					//Do something
					calamityManager.eventActive = false;
				}
				if(Input.GetButtonDown("X"))
				{
					//Do something
					calamityManager.eventActive = false;
				}
				if(Input.GetButtonDown("Y"))
				{
					//Do something
					calamityManager.eventActive = false;
				}
			}
		}
	}
}
