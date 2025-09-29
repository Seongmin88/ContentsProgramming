using UnityEngine;

public class TemperatureHeight : MonoBehaviour
{
    public float temperature = 20.0f;
    public float maxHeight = 5.0f;
    private Transform myTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTransform = GetComponent<Transform>();
        float height = (temperature / 50.0f) * maxHeight;

        myTransform.localScale = new Vector3(0.3f, height, 0.1f);
        Debug.Log("온도에 따른 높이 설정 완료:" + height);
    }

}
