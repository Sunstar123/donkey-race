﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickTemplate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called when this object is press
    void OnMouseDown()
    {
        // make sure left mouse button is pressed, not right mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // do whatever you want
        }
    }
}
