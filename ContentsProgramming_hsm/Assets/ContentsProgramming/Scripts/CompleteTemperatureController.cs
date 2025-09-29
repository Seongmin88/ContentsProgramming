using UnityEngine;

public class CompleteTemperatureController : MonoBehaviour
{
    [Header("온도 설정")]
    public float temperature = 25.0f;     // 온도
    public float maxHeight = 3.0f;        // 최대 높이
    //추가: 원래 스케일 저장용 변수
    private Vector3 baseScale;

    [Header("디버깅")]
    public bool showDebugInfo = true;     // 디버그 정보 표시
    
    private Renderer objectRenderer;       // Renderer 컴포넌트
    private float nextDebugTime = 0f;      // 다음 디버그 출력 시간
    
    void Start()
    {
        // Renderer 컴포넌트 가져오기
        objectRenderer = GetComponent<Renderer>();

        // 추가: 시작할 때 원래 X,Z 스케일 기억
        baseScale = transform.localScale;  
        
        if (objectRenderer == null)
        {
            Debug.LogError("이 GameObject에는 Renderer가 없습니다!");
        }
        
        Debug.Log("온도계 시작! 초기 온도: " + temperature + "도");
    }
    
    void Update()
    {
        // 1. 높이 제어 (온도에 비례)
        // 온도를 높이로 변환 (0~50도 범위)
        float height = Mathf.Clamp(temperature / 50.0f * maxHeight, 0.1f, maxHeight);

        // 수정: X,Z는 그대로 두고 Y만 변경
        transform.localScale = new Vector3(baseScale.x, height, baseScale.z);
        
        // 2. 색상 제어 (온도 구간별)
        if (objectRenderer != null)
        {
            if (temperature < 15.0f)
            {
                // 추운 날씨 - 파란색
                objectRenderer.material.color = Color.blue;
            }
            else if (temperature >= 15.0f && temperature < 30.0f)
            {
                // 적당한 날씨 - 녹색
                objectRenderer.material.color = Color.green;
            }
            else
            {
                // 더운 날씨 - 빨간색
                objectRenderer.material.color = Color.red;
            }
        }
        
        // 3. 디버그 정보 (1초마다 한 번씩)
        if (showDebugInfo && Time.time >= nextDebugTime)
        {
            Debug.Log("[" + gameObject.name + "] 온도: " + temperature + "도, 높이: " + height.ToString("F2"));
            nextDebugTime = Time.time + 1.0f;  // 1초 후 다시 출력
        }
    }
}