using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public new Rigidbody2D rigidbody;

    Vector2 movement;

    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + (movement*moveSpeed*Time.fixedDeltaTime));
    }
}
