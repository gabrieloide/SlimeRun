using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<LevelManager>().RemoveLevelBlock();
            FindObjectOfType<LevelManager>().createLevelBlock();
        }
    }
}
