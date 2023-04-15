using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector2 target;
    [SerializeField] float Speed;
    [SerializeField] float timeToNextStep;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Movement());
        }
    }
    IEnumerator Movement()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, Speed * Time.deltaTime);
        yield return new WaitForSeconds(timeToNextStep);
        UpdateTarget();
    }
    void UpdateTarget()
    {
        float distanceTarget = Vector2.Distance(transform.position, target);
        if (distanceTarget <= 0.01f)
        {
            target = new Vector2(target.x, target.y + 1);
        }
    }
}
