using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    [SerializeField] float timeToAppear;
    Vector2 target;
    Rigidbody2D rb;
    private float timeToDisappear;
    private float _timeToAppear;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _timeToAppear = timeToAppear;
        timeToDisappear = timeToAppear;
        target = new Vector2(transform.position.x + 1, transform.position.y);
    }
    private void Update()
    {
        AppearAndDesappear();
    }
    public void AppearAndDesappear()
    {
        timeToAppear -= Time.deltaTime;
        if (timeToAppear < 0)
        {
            timeToAppear = 0;
            //Cambiar sprite al que no tiene espinas
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(0, transform.position.y), 1);
            timeToDisappear -= Time.deltaTime;


            if (timeToDisappear < 0)
            {
                timeToDisappear = 0;
                //Cambiar sprite al que tiene espinas
                transform.position = Vector2.MoveTowards(
                    transform.position, 
                    new Vector2(target.x,
                    transform.position.y), 
                    1f); 

                timeToAppear = _timeToAppear;
                timeToDisappear = _timeToAppear;
            }
        }
    }
}
