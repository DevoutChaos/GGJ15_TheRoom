using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public Camera Perspective;

    [HideInInspector] public Interactable Highlight, LHighlight; 
    [HideInInspector] public float IntrcDis = float.MaxValue; 

	void Start () {
        if( Camera.main  != null ) Perspective= Camera.main;
	}

    void interact() {


        if(Highlight != null ) {
			if( Input.GetButtonDown("Interact")) 
                Highlight.interact();

        }
        
        LHighlight = Highlight;
        Highlight = null;
        IntrcDis = float.MaxValue;
    }


	void Update () {
/*
        if(Input.GetKeyDown(KeyCode.E)) {
            var rot = Perspective.transform.localEulerAngles.y;
            var rig = GetComponentInChildren<OVRCameraRig>();
           // rig.transform.parent = null;
            transform.localEulerAngles = new Vector3( 0, rot, 0 );
           // rig.transform.parent = transform;
            
        }
        */

        interact();
	}
}
