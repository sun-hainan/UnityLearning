# 🚀 5分钟快速验证

在正式开始8个月学习前，先确认你的环境配置正确。

> **中国大陆用户？** 本教程已适配**团结引擎（Tuanjie Engine）**，详见[团结引擎适配指南](团结引擎适配指南.md)

---

## 环境准备清单

| 组件 | 是否必需 | 安装指南 |
|------|---------|---------|
| Unity Hub / 团结Hub | ✅ 必需 | 见下方步骤1 |
| Unity / 团结引擎 | ✅ 必需 | 见下方步骤1 |
| **Visual Studio 2022** | ✅ **必需** | **[📖 Visual Studio安装指南](VisualStudio安装指南.md)** |
| Git（可选）| ⭕ 推荐 | 用于代码版本管理 |

---

## 步骤1：验证Unity/团结引擎安装（2分钟）

### 国际版Unity
1. 打开 **Unity Hub** → Projects → New Project → **3D**
2. 项目名 `Test`，点击 Create Project
3. 如果能看到 **Cube** 和天空盒，✅ **通过**

### 团结引擎（中国版）
1. 打开 **团结Hub** → 项目 → 新建项目 → **3D**
2. 项目名 `Test`，点击 创建项目
3. 如果能看到 **Cube** 和天空盒，✅ **通过**

**版本要求**：
- Unity 2021.3 LTS 或更高
- 团结引擎 1.6.x 或更高

---

## 步骤2：验证Visual Studio（2分钟）

> ⚠️ **还没有安装 VS？** → 先阅读 [Visual Studio安装指南](VisualStudio安装指南.md)

1. 在项目中，Project 窗口右键 → Create → **C# Script**，命名为 `Test`
2. **双击** 打开，看是否能启动 **Visual Studio**
3. 如果能看到代码编辑器，✅ **通过**

---

## 步骤3：运行第一个脚本（1分钟）

把这段代码复制到 `Test.cs`：

```csharp
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Debug.Log("✅ Unity/团结引擎 + Visual Studio 环境配置成功！");
    }
}
```

1. 把脚本拖到 Hierarchy 的 **Main Camera** 上
2. 点击 **Play** 按钮
3. 看 Console 窗口，如果显示 "✅ Unity/团结引擎 + Visual Studio 环境配置成功！"，✅ **全部通过**

---

## ❌ 常见问题

### Q1: Unity/团结Hub 打不开？
- 检查网络连接
- 关闭代理/VPN
- 以管理员身份运行
- 团结引擎用户：确保从 unity.cn 下载

### Q2: 双击脚本不打开 Visual Studio？
- Unity/团结 → Edit → Preferences → External Tools → External Script Editor → 选择 Visual Studio
- 详细步骤见 [Visual Studio安装指南](VisualStudio安装指南.md) 的"常见问题"部分

### Q3: Console 不显示日志？
- Window → General → Console 打开控制台窗口

### Q4: 团结引擎和国际版有什么区别？
- 版本号不同（团结1.8.x = Unity 2022.3）
- API完全相同，代码100%兼容
- 详见[团结引擎适配指南](团结引擎适配指南.md)

---

## ✅ 环境验证通过？开始你的旅程！

1. 📚 阅读 [完整自学指南](完整自学指南.md)
2. 🎮 查看 [02-2DShootEmUp](02-2DShootEmUp) 项目效果
3. 📝 记录你的学习进度 [学习检查清单](学习检查清单.md)

---

**文档版本**：v1.2  
**最后更新**：2026年4月10日  
**适配**：Unity 2021.3+ / 团结引擎 1.6+ / Visual Studio 2022
