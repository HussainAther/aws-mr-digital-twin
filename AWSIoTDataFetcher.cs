using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;  // For displaying text in MR

public class AWSIoTDataFetcher : MonoBehaviour
{
    public string apiUrl = "https://your-api-gateway-url.amazonaws.com/prod";  // Replace with your actual API Gateway URL
    public TextMeshPro sensorText;  // Assign in Unity UI

    void Start()
    {
        StartCoroutine(FetchSensorData());
    }

    IEnumerator FetchSensorData()
    {
        while (true)
        {
            UnityWebRequest request = UnityWebRequest.Get(apiUrl);
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string jsonResponse = request.downloadHandler.text;
                SensorData[] sensors = JsonHelper.FromJson<SensorData>(jsonResponse);
                if (sensors.Length > 0)
                {
                    sensorText.text = $"Temp: {sensors[0].temperature}°C\nHumidity: {sensors[0].humidity}%";
                }
            }
            else
            {
                Debug.LogError("Error fetching AWS IoT data: " + request.error);
            }

            yield return new WaitForSeconds(5);  // Fetch every 5 seconds
        }
    }
}

[System.Serializable]
public class SensorData
{
    public string device_id;
    public float temperature;
    public float humidity;
    public long timestamp;
}

// Helper class to handle JSON arrays
public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        string wrappedJson = "{\"items\":" + json + "}";
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(wrappedJson);
        return wrapper.items;
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] items;
    }
}

