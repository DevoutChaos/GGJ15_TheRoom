using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactable : MonoBehaviour {

    Transform Trnsfrm;
    Player Plyr;

    public FaceCamera GUI;

	//used for introduction
	public bool interacted = false; 

    void OnEnable() {
        Trnsfrm = transform;
        Plyr = FindObjectOfType<Player>();

        if( GUI!= null) GUI.gameObject.SetActive( false );
    }

    public virtual void interact() {
        //Debug.Log("KAPOW");

    }

    bool InArea = false;
    protected void Update() {

      if(InArea) {
            interacted = true;
        
            var p = Plyr.Perspective.WorldToViewportPoint ( Trnsfrm.position );

            var d = ((Vector2)p- new Vector2(0.5f,0.5f) ).sqrMagnitude*p.z;

            var ct = Plyr.Perspective.transform;
            var vec = ct.position - Trnsfrm.position; var mag = vec.magnitude;
            float sort = mag/Vector3.Dot( -ct.forward, vec/mag ) ;

            //Debug.Log("hi  " +Vector3.Dot( -ct.forward, (ct.position - Trnsfrm.position).normalized )+"   "+mag +"  d "+d );
            if(p.z > 0.2f && d <0.3f && sort < Plyr.IntrcDis ) {
                //
                Plyr.IntrcDis = sort;
                Plyr.Highlight = this;
            }
        }
        

        if(Plyr.LHighlight == this) {
            if( GUI!= null) GUI.DesVis = true;
        } else {
            if( GUI!= null) GUI.DesVis = false;
        }
    }
    
    void OnTriggerEnter() {
        InArea = true;
		//used for the introduction
		
    }
    void OnTriggerExit() {

        InArea = false;
    }
}
