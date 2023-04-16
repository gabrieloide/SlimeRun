using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] RectTransform screenGO;
    [SerializeField] RectTransform textButtons;
    [SerializeField] RectTransform gameOverText;
    [SerializeField] float timeToFade;
    private void OnEnable()
    {
        StartCoroutine(ShowGameOverScreen());
    }

    public IEnumerator ShowGameOverScreen()
    {
        LeanTween.moveX(screenGO, 0, timeToFade);
        yield return new WaitForSeconds(timeToFade);
        LeanTween.moveY(gameOverText, 216, 0.7f).setEaseInCubic();
        yield return new WaitForSeconds(0.7f);
        LeanTween.moveY(textButtons, 0, 0.7f).setEaseInCubic().setOnComplete(stopTime);
    }
    void stopTime()
    {
        Time.timeScale = 0;
    }
}

