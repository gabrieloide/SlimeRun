using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    string Enemy = "Enemy";
    public bool wasHit;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Enemy))
        {
            wasHit = true;
        }
    }
}