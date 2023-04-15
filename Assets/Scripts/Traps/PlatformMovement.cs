using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField]Transform[] pointsToMove;
    [SerializeField] float speed;
    int index;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, pointsToMove[index].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, pointsToMove[index].position) <= 0.01f)
        {
            index++;
            if (index == pointsToMove.Length)
            {
                index = 0;
            }
        }
    }
}
