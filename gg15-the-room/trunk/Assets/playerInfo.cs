using UnityEngine;
using System.Collections;

public class playerInfo : MonoBehaviour {

	Vector3 curPos;

	public GameObject gun;
	public bool gunAct = false;
	public Light flair;
	public bool shoot = true;
	public bool self = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gunAct == true) 
		{
			if (Input.GetAxis("shoot") >= 1 && shoot == true) 
			{
				flair.enabled = true;
				StartCoroutine(gunFlair());
				//start audio;
				shoot = false;
				if (self == true) {
					Application.Quit();
				}
			}
			if (Input.GetAxis("shoot") <= 0.001 && shoot == false) 
			{
				shoot=true;
			}
			if (Input.GetButtonDown("AltActiom")) {
				if (self == false) {
					StartCoroutine(shootSelf());
				}
				if (self == true) {
					self = false;
					gun.GetComponent<Animator>().SetBool("self", false);
				}

			}
		}

	
	}

	IEnumerator gunFlair()
		{
			yield return new WaitForSeconds (0.2f);
			flair.enabled = false;
		audio.Play ();
		}
	IEnumerator shootSelf()
	{
		gun.GetComponent<Animator>().SetBool("self", true);
		yield return new WaitForSeconds (2.0f);
		self = true;
	}

	void StopAnimat()
	{
		curPos = transform.position;
		this.GetComponent<Animator> ().enabled = false;
		this.transform.Translate (curPos);
	}

	public void showGun()
	{
		gun.SetActive (true);
		gunAct = true;
	}
}
