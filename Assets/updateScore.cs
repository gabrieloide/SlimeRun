using System.Collections;
using UnityEngine.Networking;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text;

public class updateScore : MonoBehaviour
{
    public static updateScore instance;
    [SerializeField] Text dataText;
    private const string Url = "http://localhost:5000/api/v1/scores";
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        MyFunction();
    }

    void MyFunction()
    {
        if (dataText != null)
        {
            StartCoroutine(GetData());
        }
    }
    public void OnRefreshButtonClicked()
    {
        StartCoroutine(DownloadData());
    }
    private IEnumerator DownloadData()
    {
        // Reemplaza esta URL con la URL de tus datos JSON
        string url = "http://localhost:5000/api/v1/scores";
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(request.error);
        }
        else
        {
            var jsonData = request.downloadHandler.text;
            DataArray dataArray = JsonUtility.FromJson<DataArray>("{\"dataArray\":" + jsonData + "}");
            dataText.text = "";
            foreach (data data in dataArray.dataArray)
            {
                dataText.text += data.username + ": " + data.score + "\n";
            }
        }
    }
    private IEnumerator GetData()
    {
        UnityWebRequest request = UnityWebRequest.Get(Url);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }
        else
        {
            var jsonData = request.downloadHandler.text;
            DataArray dataArray = JsonUtility.FromJson<DataArray>("{\"dataArray\":" + jsonData + "}");
            foreach (data data in dataArray.dataArray)
            {
                dataText.text += data.username + ": " + data.score + "m" + "\n";
            }
        }

    }
    public IEnumerator UploadScore(string username, int score)
    {
        // Reemplaza esta URL con la URL de tu servidor
        string url = "http://localhost:5000/api/v1/score";

        // Crea un objeto con los datos que quieres enviar
        data scoreData = new data();
        scoreData.username = username;
        scoreData.score = score;

        // Serializa el objeto en una cadena JSON
        string jsonData = JsonUtility.ToJson(scoreData);

        // Crea una solicitud UnityWebRequest
        UnityWebRequest request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // Envía la solicitud
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(request.error);
        }
        else
        {
            Debug.Log("Score uploaded successfully");
        }
    }
    [System.Serializable]
    public class DataArray
    {
        public data[] dataArray;
    }
    [Serializable]
    public class data
    {
        private string _id;
        public int score;
        public string username;
    }
}
