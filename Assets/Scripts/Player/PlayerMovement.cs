using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    string Jump = "Jump";
    public float Speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GetComponent<HurtPlayer>().wasHit)
        {
            Jumping();
        }
    }
    public void Jumping()
    {
        animator.SetTrigger(Jump);
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * Speed, ForceMode2D.Impulse);
    }
}
