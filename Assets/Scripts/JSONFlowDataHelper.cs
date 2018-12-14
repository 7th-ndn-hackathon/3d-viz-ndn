using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONFlowDataHelper : MonoBehaviour
{

    private JSONDataHandler handler;
    public GameObject hostObj;
    public GameObject flowObj;
    public GameObject[] hosts;

    private void Awake()
    {
        handler = gameObject.GetComponent<JSONDataHandler>();
        handler.readFromJSON();
        getAllHosts();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void getAllHosts()
    {
        foreach (projData.host host in handler.data.hosts)
        {
            GameObject newHost = Instantiate(hostObj);
            newHost.name = host.name;
            newHost.transform.position = new Vector3(host.location.x, host.location.y, host.location.z);
            newHost.transform.parent = flowObj.transform;
        }
    }

    void saveData()
    {
        foreach (GameObject obj in hosts)
        {
            handler.addNewHost(obj.name, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
        }

        handler.saveToJSON();
    }
}