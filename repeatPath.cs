﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatPath : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(260f, -0.02f, -9.7f);
        }
    }
}