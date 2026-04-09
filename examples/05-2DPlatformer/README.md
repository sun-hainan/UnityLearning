# 05-2DPlatformer

## 功能
完整 2D 平台跳跃游戏

## 学习点
- 2D 物理系统（Rigidbody2D）
- 2D 碰撞检测
- 地面检测
- 2D 动画系统
- 相机跟随

## 代码

### PlayerController2D.cs
```csharp
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("移动")]
    public float moveSpeed = 5f;
    
    [Header("跳跃")]
    public float jumpForce = 10f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    
    private Rigidbody2D rb;
    private bool isGrounded;
    private float horizontalInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // 获取输入
        horizontalInput = Input.GetAxis("Horizontal");
        
        // 地面检测
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        // 跳跃
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    
    void FixedUpdate()
    {
        // 移动
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        
        // 翻转角色
        if (horizontalInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (horizontalInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
```

## 步骤

1. 新建 2D 项目
2. 创建 Tilemap 地面
3. 创建 Player（Sprite + Rigidbody2D + BoxCollider2D）
4. 创建 GroundCheck 空物体（放在角色底部）
5. 添加 PlayerController2D 脚本
6. 设置 Layer（Ground）
7. 运行测试

## 练习

- [ ] 添加行走动画
- [ ] 实现二段跳
- [ ] 添加敌人（碰到扣血）
- [ ] 添加收集物（金币）
- [ ] 相机跟随玩家

## 进阶

完成这个示例后，你就具备了开发完整 2D 游戏的基础能力！
