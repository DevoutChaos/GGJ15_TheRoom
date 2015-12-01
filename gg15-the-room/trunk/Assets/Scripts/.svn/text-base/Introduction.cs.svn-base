using UnityEngine;
using System.Collections;

public class Introduction : MonoBehaviour {

	public GameObject Player;
	public GameObject introCamera;
	public GameObject introCameraAncor;
	public GameObject Item;
	public GameObject screen;
	public Sprite[] computerImage = new Sprite[4];
	public bool task1 = false;
	public bool task2 = false;
	public bool task3 = false;
	public Vector3 chairVec;
	//public GameObject chair;
	//public float sitHeight;
	

	// Use this for initialization
	void Start () {

		//look left
		//look right 
		//activate object on table
		//blue screen

		screen.GetComponent<SpriteRenderer> ().sprite = computerImage [0];
		//chairVec.Set(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z);

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (task1 == false)
		{
			Debug.Log("look left");
			if (lookLeft() == true)
			{
				task1 = true;
			}
		}
		else if (task2 == false)
		{
			Debug.Log("look right");
			if (lookRight() == true)
			{
				task2 = true;
			}		
		}
		else if (task3 == false)
		{
			Debug.Log("pick up pen");
			if (Input.GetButtonDown("Interact"))
			{
				task3 = true;
			}
			/* once jim has done the interactable 
			if (interactObject() == true)
			{
				task3 = true;
			}
			 */
		}
		else if (task1 == true && task2 == true && task3 == true)
		{
			Debug.Log("end intro");
			screen.GetComponent<SpriteRenderer> ().sprite = computerImage [3];
			introCamera.animation.Play();
			introCamera.transform.Translate(chairVec * Time.deltaTime);
			
			//call liam script 
			//enable sitting 
			//turn this script off
		}
	}

	void swapCam()
	{
		Debug.Log ("swap cam");
		introCamera.animation.enabled = false;
		this.transform.parent = Player.transform;
		Player.SetActive (true);
	}

	bool lookCenter()
	{
		if (introCameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 315  && introCameraAncor.GetComponent<Transform>().rotation.eulerAngles.y <= 45)
		{
			return true;
		}
		else return false;
	}

	bool lookLeft()
	{
		if (introCameraAncor.GetComponent<Transform>().rotation.eulerAngles.y <= 135 && introCameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 0)
		{
			screen.GetComponent<SpriteRenderer> ().sprite = computerImage [1];
			return true;
		}		
		else return false;
	}

	bool lookRight()
	{
		if (introCameraAncor.GetComponent<Transform>().rotation.eulerAngles.y >= 225 && Player.GetComponent<Transform>().rotation.eulerAngles.y <= 360)
		{
			screen.GetComponent<SpriteRenderer> ().sprite = computerImage [2];
			return true;
		}
		
		else return false;
	}

	bool interactObject()
	{
		if (Item.GetComponent<Interactable>().interacted == true)
		{
			return true;
		}
		else return false;
	}
}
