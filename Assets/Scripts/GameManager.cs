using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    HurtPlayer hurtPlayer;
    public float PathTraveled;
    [SerializeField] Transform playerTransform;
    public int currentY() => Mathf.FloorToInt(playerTransform.position.y);
    public GameObject GameOverScreen;

    public string username;
    [HideInInspector] public int scoreP;
    public bool canUpdate = false;
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

