using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveParticleData : MonoBehaviour {

    // The target marker.
    public Transform[] targets;
    public Transform target;
    public int targetIndex;

    // Speed in units per sec.
    public float speed = 5;

    private void Start()
    {
        targetIndex = 0;
    }

    void Update()
    {
        if (transform.position == target.position)
        {
            if (targetIndex == targets.Length)
            {
                targetIndex = 0;
            }
            else
            {
                targetIndex++;
            }

            target = targets[targetIndex];
        }
        else
        {
            // The step size is equal to speed times frame time.
            float step = speed * Time.deltaTime;

            // Move our position a step closer to the target.
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    void setTarget(GameObject obj)
    {
        target = obj.transform;
    }



}
