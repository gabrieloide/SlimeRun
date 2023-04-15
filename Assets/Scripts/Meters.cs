using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Meters : MonoBehaviour
{
    [SerializeField] TMP_Text lenghtText;
    [SerializeField] Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        lenghtText.text = playerTransform.position.y.ToString("f0") + "m";
        if (playerTransform.position.y > GameManager.instance.PathTraveled)
        {
            GameManager.instance.PathTraveled = playerTransform.position.y;
        }
    }
}
