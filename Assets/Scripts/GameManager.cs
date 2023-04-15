using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    HurtPlayer hurtPlayer;
    public float PathTraveled;
    public GameObject GameOverScreen;
    private void Awake()
    {
        hurtPlayer = FindObjectOfType<HurtPlayer>();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (hurtPlayer.wasHit)
        {
            GameOverScreen.SetActive(true);
        }
    }
}
