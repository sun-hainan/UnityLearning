# Example-01-HelloUnity

> 最基础的Unity项目，适合零基础用户第一步体验。

---

## 项目简介

本项目展示：
- 如何创建新场景
- 如何添加基本3D物体
- 如何编写第一个脚本
- 如何运行游戏

---

## 文件结构

```
Example-01-HelloUnity/
├── Scripts/
│   └── Rotator.cs          # 旋转动画脚本
├── Scenes/
│   └── MainScene.unity     # 主场景
└── README.md               # 本文件
```

---

## 快速开始

### 1. 创建项目

1. 打开 Unity/团结Hub
2. 新建项目 → 选择 **3D** 模板
3. 项目名：`HelloUnity`
4. 点击创建

### 2. 添加物体

1. Hierarchy 窗口右键 → **3D Object** → **Cube**
2. 选中 Cube，Inspector 中设置 Position 为 (0, 0, 0)

### 3. 添加脚本

1. Project 窗口右键 → **Create** → **C# Script**，命名为 `Rotator`
2. 双击打开，替换为以下代码：

```csharp
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 50f;

    void Update()
    {
        // 每帧旋转物体
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
```

3. 将脚本拖到 Cube 上

### 4. 运行

点击 **Play** 按钮，看到 Cube 旋转 → ✅ 成功！

---

## 学习要点

| 概念 | 说明 |
|------|------|
| `MonoBehaviour` | Unity脚本的基类 |
| `Update()` | 每帧调用一次 |
| `transform` | 物体的位置、旋转、缩放 |
| `Time.deltaTime` | 上一帧到当前帧的时间间隔 |

---

## 扩展练习

- [ ] 修改 `speed` 值，观察旋转速度变化
- [ ] 改为 `Vector3.right` 或 `Vector3.forward`，观察不同轴向旋转
- [ ] 添加第二个 Cube，给不同颜色

---

**难度**：⭐  
**预计时间**：10分钟
