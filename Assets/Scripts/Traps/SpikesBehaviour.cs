using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesBehaviour : MonoBehaviour
{
    SpriteRenderer spikeSpriteRenderer;
    [SerializeField]Sprite withSpikes, withoutSpikes; 
    [SerializeField] float timeToAppear;
    float _timeToAppear, timeToDisappear;
    void Start()
    {
        _timeToAppear = timeToAppear;
        timeToDisappear = timeToAppear;
        spikeSpriteRenderer = GetComponent<SpriteRenderer>();
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
            spikeSpriteRenderer.sprite = withoutSpikes; 

            timeToDisappear -= Time.deltaTime;


            if (timeToDisappear < 0)
            {
                timeToDisappear = 0;
                //Cambiar sprite al que tiene espinas
                spikeSpriteRenderer.sprite = withSpikes;
                timeToAppear = _timeToAppear;
                timeToDisappear = _timeToAppear;
            }
        }
    }
}
