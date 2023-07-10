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
    public void showladerShip()
    {
        showLeadership.SetActive(true);
    }
    public void UnShowladerShip()
    {
        showLeadership.SetActive(false);
    }
}
