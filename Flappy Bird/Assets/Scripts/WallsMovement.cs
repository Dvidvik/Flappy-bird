using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    void Update()
    {
        body.velocity = Vector2.left * speed;
    }

}
