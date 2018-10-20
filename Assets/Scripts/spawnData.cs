using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnData : MonoBehaviour {

    // Use this for initialization
    public GameObject dataType_general;
    public GameObject otherDataType;
    public GameObject target;
	void Start () {
        Instantiate(dataType_general);
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
