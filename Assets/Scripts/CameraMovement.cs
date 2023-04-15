using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerT;
    [SerializeField] float speed;
    [SerializeField] Vector3 offset;
    [SerializeField] float maxDistance;
    void Update()
    {
        maxDistance = playerT.position.y;
        if (transform.position.y < maxDistance)
        {
            transform.position = Vector3.Lerp(transform.position, playerT.position + offset, speed * Time.deltaTime);
        }
    }
}
