using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    Vector3 startPosition;
    Quaternion startRotation;
    bool isKinematicInitial;
    Rigidbody rb;
    void Start()
    {
        startPosition= transform.position;
        startRotation= transform.rotation;
        rb = GetComponent<Rigidbody>();
        isKinematicInitial = rb.isKinematic;
    }
    public void Reset()
    {
        rb.isKinematic = true;
        transform.position = startPosition;
        transform.rotation = startRotation;
        rb.isKinematic = isKinematicInitial;
    }


}
