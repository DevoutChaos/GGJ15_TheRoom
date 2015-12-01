using UnityEngine;
using System.Collections;

public class playerSit : MonoBehaviour {

	public GameObject camera;
	public GameObject player;
	public GameObject chair;

	public Vector3 chairVec;

	private float standHeight;
	public float sitHeight;

	bool yesSit;

	// Use this for initialization
	void Start () {
		standHeight = camera.transform.position.y;
		chairVec.Set(chair.transform.position.x, sitHeight, chair.transform.position.z);
		//cameraVec.Set(chair.transform.position.x, sitHeight, chair.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (yesSit == true)
		{
			player.transform.Translate(chairVec * Time.deltaTime);
		}
	}

	public void sit()
	{
		yesSit = true;
	}

	public void stand()
	{
		yesSit = false;
	}
}
