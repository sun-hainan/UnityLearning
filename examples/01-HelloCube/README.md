# 01-HelloCube

## 功能
创建一个旋转的 Cube

## 学习点
- Scene 视图操作
- 创建 GameObject
- 编写第一个脚本
- 理解 Update 函数

## 代码

```csharp
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // 旋转速度（度/秒）
    public float speed = 90f;

    void Update()
    {
        // 每帧围绕 Y 轴旋转
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
```

## 步骤

1. 新建 3D 项目
2. Hierarchy 中选中 Cube
3. Add Component → New Script → Rotator
4. 运行游戏
5. 调整 speed 值观察效果

## 练习

- [ ] 让 Cube 同时围绕 X 轴旋转
- [ ] 添加 public 颜色变量，改变 Cube 颜色
- [ ] 按空格键加速旋转
