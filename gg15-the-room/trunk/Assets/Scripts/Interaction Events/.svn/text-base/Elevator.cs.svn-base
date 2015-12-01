using UnityEngine;
using System.Collections;

public class Elevator : Interactable {


	public GameObject liftDoorRight;
	public GameObject liftDoorLeft;

	public AudioSource lift;
	public AudioClip music;

	public bool open = false;

	public override void interact ()
	{
		if (open == false) {
						liftDoorLeft.GetComponent<Animator> ().SetBool ("openDoor", true);
						liftDoorRight.GetComponent<Animator> ().SetBool ("openDoor", true);
			open = true;
				} else {
			liftDoorLeft.GetComponent<Animator> ().SetBool ("openDoor", false);
			liftDoorRight.GetComponent<Animator> ().SetBool ("openDoor", false);

			StartCoroutine(startMusic());
				}
	}

	IEnumerator startMusic()
	{
		lift.Play ();
		yield return new WaitForSeconds(music.length);

		liftDoorLeft.GetComponent<Animator> ().SetBool ("openDoor", true);
		liftDoorRight.GetComponent<Animator> ().SetBool ("openDoor", true);
		open = false;
	}
	/*
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
	}
	*/
}