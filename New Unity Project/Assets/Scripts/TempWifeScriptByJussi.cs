﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempWifeScriptByJussi : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector2.right * speed);
    }
}
