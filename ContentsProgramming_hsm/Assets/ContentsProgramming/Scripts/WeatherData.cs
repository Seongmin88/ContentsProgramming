using UnityEngine;

public class WeatherData : MonoBehaviour
{
    public float temperature = 25.0f;
    public float humidity = 60.0f;
    public string weatherType = "맑음";
    public bool isRaining = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("현재 날씨 정보: ");
        Debug.Log("현재 온도:" + temperature + "도");
        Debug.Log("현재 습도: " + humidity + "%");
        Debug.Log("날씨 상태: " + weatherType);

        if (isRaining)
        {
            Debug.Log("비가 오고 있습니다!");
        }
        else
        {
            Debug.Log("비가 오지 않습니다.");
        }
    }

}
