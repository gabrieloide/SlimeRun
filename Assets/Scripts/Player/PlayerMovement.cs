using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector2 target;
    Rigidbody2D rb;
    public float Speed;
    [SerializeField] float timeToNextStep;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //StartCoroutine(Movement());
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * Speed, ForceMode2D.Impulse);
        }
    }
}
