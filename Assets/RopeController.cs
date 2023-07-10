using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    public int numNodes = 10;
    public float nodeSpacing = 0.1f;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        lineRenderer.positionCount = numNodes;

        Vector3[] nodePositions = new Vector3[numNodes];

        for (int i = 0; i < numNodes; i++)
        {
            nodePositions[i] = new Vector3(0, i * nodeSpacing, 0);
        }

        lineRenderer.SetPositions(nodePositions);
    }
}