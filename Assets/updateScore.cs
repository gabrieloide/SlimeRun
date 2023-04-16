using System.Collections;
using UnityEngine.Networking;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    [SerializeField]Text text;
    IEnumerator Start()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:5000/api/v1/scores"))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string json = www.downloadHandler.text;
                text.text = json;
            }
        }
    }
}