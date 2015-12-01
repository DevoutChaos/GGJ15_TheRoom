using UnityEngine;
using System.Collections;

public class GirlPhone : Calamity
{
		public AudioClip[] list;
		public AudioSource Source;
		public RndEventManager calamityManager;
		public bool CreepyLiftGirl;
		public bool done = false;
	
		public override bool proc ()
		{
				
				Debug.Log ("calling girl");
				//this.gameObject.SetActive (true);
				if (done == false) {
						if (!Source.isPlaying) {
								Debug.Log ("passed source");						
								StartCoroutine (PlaySound ());					
								Debug.Log ("FUCK");		
								return true;
						}
						
				} else {
						calamityManager.EventPicker ();
						return true;
				}
		return true;
	}

		IEnumerator PlaySound ()
		{
				
				for (int i = 0; i < list.Length; i++) {
						Source.clip = list [i];
						Source.Play ();
						yield return new WaitForSeconds (list [i].length);
				}
				
				CreepyLiftGirl = true;
				calamityManager.Reset ();
				done = true;
				//Destroy (gameObject);
		}
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{

		}
}
