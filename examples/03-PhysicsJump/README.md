# 03-PhysicsJump

## 功能
空格跳跃，物理系统

## 学习点
- Rigidbody 组件
- AddForce 方法
- ForceMode 类型
- 地面检测

## 代码

```csharp
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public LayerMask groundLayer;
    
    private Rigidbody rb;
    private bool isGrounded;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        // 检测地面
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
        
        // 跳跃
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
```

## 步骤

1. 创建 Plane，设置 Tag 为 Ground
2. 创建 Capsule 作为玩家
3. 添加 Rigidbody 组件
4. 添加 PlayerJump 脚本
5. 设置 Ground Layer
6. 运行游戏，按空格跳跃

## 练习

- [ ] 实现二段跳
- [ ] 添加跳跃动画
- [ ] 长按空格跳得更高
