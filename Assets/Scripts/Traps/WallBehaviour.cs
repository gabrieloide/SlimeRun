using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    [SerializeField] float timeToAppear;
    private float timeToDisappear;
    private float _timeToAppear;

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
            transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, 0);
            timeToDisappear -= Time.deltaTime;


            if (timeToDisappear < 0)
            {
                timeToDisappear = 0;
                //Cambiar sprite al que tiene espinas
                transform.position = Vector2.MoveTowards(transform.position, 
                    new Vector2(transform.position.x + 2,
                    transform.position.y), 
                    0.5f); 

                timeToAppear = _timeToAppear;
                timeToDisappear = _timeToAppear;
            }
        }
    }
}
