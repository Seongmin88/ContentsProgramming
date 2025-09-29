using UnityEngine;

public class TemperatureColor : MonoBehaviour
{
    // 온도 변수
    public float temperature = 25.0f;//온도
    public Color coldColor = Color.blue;//차가운 색상   
    public Color hotColor = Color.red; //뜨거운 색상
    public Color normalColor = Color.green; // 보통 색상

    private Renderer myRenderer;
    void Start()
    {
        // Renderer 컴포넌트 가져오기
        myRenderer = GetComponent<Renderer>();

        
        // 온도에 따라 색상 결정
        if (temperature < 10.0f)
        {
            myRenderer.material.color = Color.blue;
            Debug.Log(temperature + "도: 차가워요! (파란색)");
        }
        else if (temperature < 30.0f)
        {
            myRenderer.material.color = Color.green;
            Debug.Log(temperature + "도: 적당해요! (녹색)");
        }
        else
        {
            myRenderer.material.color = Color.red;
            Debug.Log(temperature + "도: 뜨거워요! (빨간색)");
        }
    }
}