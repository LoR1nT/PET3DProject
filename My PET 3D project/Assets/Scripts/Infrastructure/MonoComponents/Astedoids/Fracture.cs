﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fracture : MonoBehaviour
{
    [Tooltip("\"Fractured\" is the object that this will break into")]
    public GameObject fractured;

    private void OnCollisionEnter(Collision collision)
    {
        FractureObject();
    }

    private void OnCollisionStay(Collision collision)
    {
        FractureObject();
    }

    public void FractureObject()
    {
        Instantiate(fractured, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
