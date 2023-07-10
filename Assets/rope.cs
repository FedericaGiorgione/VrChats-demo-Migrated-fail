using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
    public Rigidbody end1;
    public Rigidbody end2;
    public float ropeMass = 0.1f;
    public float ropeDrag = 0.1f;
    public float ropeAngularDrag = 0.1f;

    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 2;
        line.SetPosition(0, end1.transform.position);
        line.SetPosition(1, end2.transform.position);
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rigidbodies)
        {
            rb.mass = ropeMass;
            rb.drag = ropeDrag;
            rb.angularDrag = ropeAngularDrag;
        }
    }

    void FixedUpdate()
    {
        line.SetPosition(0, end1.transform.position);
        line.SetPosition(1, end2.transform.position);
    }
}