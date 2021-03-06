﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveData : MonoBehaviour
{
    // The target marker.
    public Transform target;

    // Speed in units per sec.
    public float speed = 5;

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if(transform.position == target.position)
        {
            Destroy(gameObject);
        }
    }

    void setTarget(GameObject obj)
    {
        target = obj.transform;
    }



}