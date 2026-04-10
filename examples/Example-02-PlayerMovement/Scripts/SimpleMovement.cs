using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        // 获取输入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // 移动物体
        transform.position += movement * speed * Time.deltaTime;
    }
}