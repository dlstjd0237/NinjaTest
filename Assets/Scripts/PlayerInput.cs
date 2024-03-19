using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PlayerInput : MonoBehaviour
{
    public Action<Vector2> moveAct;
    public Action<Vector2> onPointerChange;

    Vector2 dir;

    Vector3 mousePoint;

    private void Update()
    {
        dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        mousePoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, -Camera.main.transform.position.z));

        moveAct?.Invoke(dir);
        onPointerChange?.Invoke(mousePoint);
    }
}