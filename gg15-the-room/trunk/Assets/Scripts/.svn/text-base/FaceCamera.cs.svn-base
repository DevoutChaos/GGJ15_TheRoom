using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
    //also fade in 
    Transform Trnsfrm, Cam;
    public bool Rotate = true;
    CanvasRenderer CR;
	// Use this for initialization
	void OnEnable () {
	    Trnsfrm = transform;
        Cam = FindObjectOfType<Player>().Perspective.transform;
        CR = GetComponent<CanvasRenderer>();
	}
	
    bool _DesVis  = false;
    public bool DesVis {
        get {  return _DesVis; }
        set {
            if( value && !gameObject.activeSelf ) gameObject.SetActive(true);
            _DesVis = value;
        }
    }
	// Update is called once per frame

    float Alpha = 0;
	void Update () {

        float spd = 4.0f;
        if(DesVis && Alpha < 1.0f) {
            Alpha = Mathf.Min( Alpha + Time.deltaTime *spd, 1.0f );
            CR.SetAlpha( Mathf.Sin( Alpha) );
        } else if(!DesVis && Alpha >0) {
            Alpha -= Time.deltaTime *spd;
           
            if(Alpha < 0) {
                Alpha = 0;
                gameObject.SetActive(false);
                return;
            }   
             CR.SetAlpha( Mathf.Sin( Alpha) );
        }


        if(Rotate) { 
	    // position = Highlight.transform.position;
            Trnsfrm.LookAt( Cam.position );          
            Trnsfrm.Rotate( Vector3.up, 180.0f );
        }
    //    var y = Trnsfrm.localEulerAngles.y;

       // Trnsfrm.rotation = Quaternion.Lerp( Trnsfrm.rotation, Quaternion.identity, 0.5f);

      //  var eulers = Trnsfrm.localEulerAngles; eulers.y = y;
    //    Trnsfrm.localEulerAngles = eulers;


      //  position += Vector3.up*0.5f; // (rotation* Vector3.forward )  * Highlight.GetComponent<SphereCollider>().radius*0.5f;
            
	}
}
