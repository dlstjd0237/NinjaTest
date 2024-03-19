using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{

    PlayerInput playerInput;
    Rigidbody2D rigid2D;

    float speed = 6f;

    private void Awake()
    {
        playerInput = FindObjectOfType<PlayerInput>();
        rigid2D = GetComponent<Rigidbody2D>();

        playerInput.moveAct += Move;
    }

    void Move(Vector2 dir)
    {
        dir = dir.normalized;
        rigid2D.velocity = dir * speed;
    }
}