# 02-PlayerMovement

## 功能
WASD 控制角色移动

## 学习点
- Input 系统（GetAxis）
- Transform 位置控制
- Time.deltaTime 概念

## 代码

```csharp
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        // 获取输入
        float horizontal = Input.GetAxis("Horizontal"); // A/D 或左右箭头
        float vertical = Input.GetAxis("Vertical");     // W/S 或上下箭头
        
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // 应用移动
        transform.position += movement * speed * Time.deltaTime;
    }
}
```

## 步骤

1. 新建 3D 项目
2. 创建 Plane 作为地面
3. 创建 Capsule 作为玩家
4. 添加 PlayerMovement 脚本
5. 运行游戏，用 WASD 移动

## 练习

- [ ] 限制玩家不超出边界
- [ ] 添加 Shift 加速功能
- [ ] 让角色面向移动方向
