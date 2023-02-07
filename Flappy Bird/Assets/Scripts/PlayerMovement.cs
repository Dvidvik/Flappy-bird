using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int jumpHight;
    public Rigidbody2D body;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * jumpHight);
            print("Space was pressed");
        }
    }
}
