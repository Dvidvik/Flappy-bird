using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float jumpHight;
    public float fall;
    public Rigidbody2D body;

    private void Update()
    {
        float positionY = transform.position.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.MovePosition(new Vector2(0, positionY + jumpHight));
            print("Space was pressed");
        }
        body.MovePosition(new Vector2(0, positionY - fall));

    }
}
