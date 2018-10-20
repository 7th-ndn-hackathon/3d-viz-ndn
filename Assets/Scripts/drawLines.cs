using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLines : MonoBehaviour {

    public LineRenderer lineDrawer;
    public GameObject firstLoc;
    public GameObject secondLoc;
	// Use this for initialization
	void Start () {
        lineDrawer.SetPosition(0, firstLoc.transform.position);
        lineDrawer.SetPosition(1, secondLoc.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
