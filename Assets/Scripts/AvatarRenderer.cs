using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarRenderer : MonoBehaviour
{
    Animator animator;
    SpriteRenderer spriteRenderer;
    PlayerInput playerInput;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponentInParent<PlayerInput>();
    }

    private void Start()
    {
        playerInput.moveAct += onMovement;
        playerInput.onPointerChange += onDirChange;
    }

    private void onMovement(Vector2 dir)
    {
        dir = dir.normalized;
        animator.SetFloat("move", dir.magnitude);
    }

    private void onDirChange(Vector2 dir)
    {
        if (dir.x > transform.position.x)
            spriteRenderer.flipX = false;
        if (dir.x < transform.position.x)
            spriteRenderer.flipX = true;
    }
}