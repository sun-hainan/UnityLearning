# 🚀 5分钟快速验证

在正式开始8个月学习前，先确认你的环境配置正确。

---

## 步骤1：验证Unity安装（2分钟）

1. 打开 **Unity Hub** → Projects → New Project → **3D (URP)**
2. 项目名 `Test`，点击 Create Project
3. 如果能看到 **Cube** 和天空盒，✅ **通过**

![预期效果](imgs/quickstart/unity-opened.png)

---

## 步骤2：验证脚本环境（1分钟）

1. 在项目中，Project 窗口右键 → Create → **C# Script**，命名为 `Test`
2. 双击打开，看是否能启动 **Visual Studio / Rider**
3. 如果能看到代码编辑器，✅ **通过**

---

## 步骤3：运行第一个脚本（2分钟）

把这段代码复制到 `Test.cs`：

```csharp
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Debug.Log("✅ Unity 环境配置成功！");
    }
}
```

1. 把脚本拖到 Hierarchy 的 **Main Camera** 上
2. 点击 **Play** 按钮
3. 看 Console 窗口，如果显示 "✅ Unity 环境配置成功！"，✅ **全部通过**

---

## ❌ 常见问题

### Q1: Unity Hub 打不开？
- 检查网络连接
- 关闭代理/VPN
- 以管理员身份运行

### Q2: 双击脚本不打开 Visual Studio？
- Unity → Edit → Preferences → External Tools → External Script Editor → 选择 Visual Studio

### Q3: Console 不显示日志？
- Window → General → Console 打开控制台窗口

---

## ✅ 环境验证通过？开始你的旅程！

1. 📚 阅读 [完整自学指南](完整自学指南.md)
2. 🎮 查看 [02-2DShootEmUp](02-2DShootEmUp) 项目效果
3. 📝 记录你的学习进度

---

**文档版本**：v1.0  
**最后更新**：2026年4月9日