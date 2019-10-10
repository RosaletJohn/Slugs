using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSquareSupport : MonoBehaviour

{
    public float moveSpeed = 1f;

    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.gravityScale = 20;
    }
    //Used Fixed Update for Physics code because it will mess in Update.
    private void FixedUpdate()
    {
        
    }
}
