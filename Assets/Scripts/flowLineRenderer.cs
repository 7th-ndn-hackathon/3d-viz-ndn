using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowLineRenderer : MonoBehaviour {

    public Material mat;
    public Color baseColor;

    public Transform[] points;
    public Color[] colors;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnPostRender()
    {
        Render(points, colors);
    }

    void OnDrawGizmos()
    {
        Render(points, colors);
    }

    void Render(Transform[] points, Color[] colors)
    {
        if(!ValidateInputs(points, colors))
        {
            Debug.Log("didnt work");
            return;
        }

        GL.Begin(GL.LINES);
        mat.SetPass(0);

        for (int i = 0; i < points.Length; i++)
        {
            if(i != points.Length - 1)
            {
                GL.Color(baseColor);
                GL.Vertex(points[i].position);
                GL.Color(colors[i]);
                GL.Vertex(points[i + 1].position);
            }
        }

        GL.End();
    }

    private bool ValidateInputs(Transform[] points, Color[] colors)
    {
        return points != null && colors != null && points.Length == colors.Length;
    }
}
