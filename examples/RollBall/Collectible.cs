using UnityEngine;

/// <summary>
/// 可收集物品
/// 功能：旋转动画效果
/// </summary>
public class Collectible : MonoBehaviour
{
    [Header("动画设置")]
    public float rotationSpeed = 50f;
    public float floatAmplitude = 0.5f;
    public float floatFrequency = 1f;
    
    private Vector3 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
    }
    
    void Update()
    {
        // 旋转效果
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        
        // 上下浮动效果
        float newY = startPosition.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}