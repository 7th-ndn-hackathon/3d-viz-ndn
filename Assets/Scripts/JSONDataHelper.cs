using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONDataHelper : MonoBehaviour {

    private JSONDataHandler handler;
    public GameObject[] hosts;

    private void Start()
    {
        handler = gameObject.GetComponent<JSONDataHandler>();
        getAllHosts();
    }

    // Update is called once per frame
    void Update ()
    {
		if(Input.GetKey(KeyCode.S))
        {
            saveData();
        }
	}

    void getAllHosts()
    {
        hosts = GameObject.FindGameObjectsWithTag("Host");
    }

    void saveData()
    {
        foreach(GameObject obj in hosts)
        {
            handler.addNewHost(obj.name, obj.transform.position.x, obj.transform.position.y, transform.position.z);
        }

        handler.saveToJSON();
    }
}
