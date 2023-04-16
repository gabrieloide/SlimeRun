using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UpdateName : MonoBehaviour
{
    public TMP_InputField usernameInputField;
    public void OnSubmitButtonClicked()
    {
        string username = usernameInputField.text;
        int score = GetScore();
         StartCoroutine(FindObjectOfType<updateScore>().UploadScore(username, score));
        StartCoroutine(backToMainMenu());
    }
    private int GetScore()
    {
        // Devuelve el puntaje del jugador
        return Mathf.CeilToInt(GameManager.instance.currentY());
    }
    IEnumerator backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        yield return new WaitForSeconds(1.5f);
    }
}
