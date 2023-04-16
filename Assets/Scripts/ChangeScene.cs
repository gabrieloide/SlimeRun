using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject showLeadership;
    public void changeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void showladerShip()
    {
        showLeadership.SetActive(false);
    }
}
