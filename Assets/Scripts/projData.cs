
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class projData
{
    public List<host> hosts = new List<host>();

    [System.Serializable]
    public class host
    {
        public string name;
        public vector location;

        public host(string pointName, float x, float y, float z)
        {
            name = pointName;
            location = new vector(x, y, z);
        }

        [System.Serializable]
        public class vector
        {
            public float x;
            public float y;
            public float z;

            public vector(float xVal, float yVal, float zVal)
            {
                x = xVal;
                y = yVal;
                z = zVal;
            }
        }
    }
}