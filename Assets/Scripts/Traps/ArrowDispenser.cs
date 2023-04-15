using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDispenser : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] float arrowSpeed;
    [SerializeField] float attackSpeed;
    [SerializeField] float timeToDestroy;

    void Start()
    {
        InvokeRepeating("shootArrow", 0, attackSpeed);
    }
    void shootArrow()
    {
        GameObject a = Instantiate(arrow, transform.position, Quaternion.identity, transform);
        a.GetComponent<Rigidbody2D>().velocity = new Vector2(arrowSpeed, 0);
        Destroy(a, timeToDestroy);
    }

}
