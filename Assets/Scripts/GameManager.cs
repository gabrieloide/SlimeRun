using System.Collections;
using UnityEngine.Networking;
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
[System.Serializable]
public class ScoreEntry
{
    public string username;
    public int score;
}
