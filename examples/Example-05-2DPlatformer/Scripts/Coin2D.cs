using UnityEngine;

public class Coin2D : MonoBehaviour
{
    public float rotationSpeed = 100f;
    
    void Update()
    {
        // 旋转动画
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
