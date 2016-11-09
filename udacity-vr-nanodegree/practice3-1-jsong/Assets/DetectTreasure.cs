﻿using UnityEngine;
using System.Collections;

public class DetectTreasure : MonoBehaviour {

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
    }
}
