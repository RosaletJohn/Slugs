﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSquareSupport : MonoBehaviour

{
    public float moveSpeed = 1f;
    private float verticalInput;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    //Used Fixed Update for Physics code because it will mess in Update.
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
       
    }
}
