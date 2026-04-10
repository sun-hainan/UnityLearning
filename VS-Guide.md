# 🔧 Visual Studio 安装与配置指南

> 本指南针对 Unity/团结引擎开发，详细说明 Visual Studio 的安装和配置步骤。

---

## 为什么需要 Visual Studio？

Visual Studio 是 Unity/团结引擎的官方推荐代码编辑器，提供：
- ✅ 代码智能提示（IntelliSense）
- ✅ 断点调试功能
- ✅ Unity API 自动补全
- ✅ 一键跳转到 Unity 文档

---

## 下载地址

### 方式一：通过 Unity/团结 Hub 安装（推荐）

安装 Unity/团结引擎时，勾选：
- ✅ **Microsoft Visual Studio Community**
- 会自动下载安装 VS 并配置好 Unity 开发环境

### 方式二：官网单独下载

| 版本 | 下载地址 | 说明 |
|------|---------|------|
| VS Community 2022 | https://visualstudio.microsoft.com/zh-hans/vs/ | 免费，个人/学习用 |
| VS Professional | https://visualstudio.microsoft.com/zh-hans/vs/professional/ | 付费 |

---

## 安装步骤（中国大陆优化版）

### 步骤 1：下载 Visual Studio Installer

1. 访问 https://visualstudio.microsoft.com/zh-hans/vs/
2. 点击 **"下载 Visual Studio"** → 选择 **Community 2022**
3. 下载 `VisualStudioSetup.exe`

> 💡 **下载慢？** 可尝试切换网络或使用下载工具

### 步骤 2：运行安装程序

1. 双击运行 `VisualStudioSetup.exe`
2. 点击 **"继续"**
3. 等待安装程序下载必要文件（约 2-5 分钟）

### 步骤 3：选择工作负载

在 **"工作负载"** 标签页，勾选：

#### 必选项（Unity开发必需）
```
☑️ 使用 Unity 的游戏开发
   └─ Unity 编辑器（可选）
   └─ Visual Studio Tools for Unity
```

#### 推荐选项（C#开发）
```
☑️ .NET 桌面开发
   └─ .NET Framework 4.7.2+ 目标包
```

#### 可选（根据需要）
```
☐ 使用 C++ 的游戏开发（如需 native 插件开发）
☐ Python 开发（如需要）
```

> 💡 只需勾选 **"使用 Unity 的游戏开发"** 即可开始 Unity 编程

### 步骤 4：修改安装位置（可选）

点击 **"安装位置"** 标签：
- **IDE 路径**：建议保持默认 `C:\Program Files\Microsoft Visual Studio\2022\Community`
- **下载缓存**：可改为其他盘，如 `D:\VS_Cache`

### 步骤 5：开始安装

1. 点击右下角 **"安装"** 按钮
2. 等待下载和安装（根据网络情况，约 10-30 分钟）
3. 安装完成后，点击 **"启动"**

---

## 配置 Unity/团结引擎与 Visual Studio 关联

### 方法 1：在 Unity/团结中设置（推荐）

1. 打开 Unity/团结引擎
2. 菜单栏：**Edit** → **Preferences**（首选项）
3. 左侧选择 **External Tools**（外部工具）
4. **External Script Editor** 下拉框选择 **Visual Studio 2022**
5. 勾选：
   - ✅ **Editor Attaching**（允许调试）
   - ✅ **Generate .csproj files**（生成项目文件）

![设置示意图](imgs/vs-setup/preferences.png)

### 方法 2：在 Visual Studio 中安装 Unity 插件

如果已安装 VS 但没装 Unity 工具：

1. 打开 Visual Studio 2022
2. 菜单栏：**扩展** → **管理扩展**
3. 搜索 **"Visual Studio Tools for Unity"**
4. 点击 **下载** → 关闭 VS 完成安装

---

## 验证安装

### 测试 1：打开脚本

1. 在 Unity/团结中创建新项目
2. Project 窗口右键 → **Create** → **C# Script**，命名为 `Test`
3. **双击** 脚本文件
4. 如果自动打开 Visual Studio 并显示代码 → ✅ 成功

### 测试 2：智能提示

在 VS 中输入以下代码，看是否有自动提示：

```csharp
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        // 输入 transform. 应该出现提示列表
        transform.
    }
}
```

如果出现类似下图的提示 → ✅ 成功

```
transform.
    ├─ position
    ├─ rotation
    ├─ localScale
    └─ ...
```

### 测试 3：调试功能

1. 在 VS 中，点击代码行号左侧添加 **断点**（红点）
2. 在 Unity 中点击 **Play** 运行游戏
3. 回到 VS，按 **F5** 或点击 **"附加到 Unity"**
4. 断点被触发，可单步调试 → ✅ 成功

---

## 常见问题

### Q1: 双击脚本不打开 Visual Studio？

**解决**：
1. Unity → Edit → Preferences → External Tools
2. External Script Editor 选择 Visual Studio 2022
3. 如果列表中没有，点击 **Browse...** 手动选择：
   - 路径：`C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe`

### Q2: Visual Studio 打开但无法识别 Unity API？

**解决**：
1. 在 VS 中，右键项目 → **"重新生成解决方案"**
2. 或 Unity → Assets → **Open C# Project**
3. 等待 VS 加载完成（首次可能需要 1-2 分钟）

### Q3: 安装时提示需要 .NET Framework？

**解决**：
- 访问 https://dotnet.microsoft.com/download/dotnet-framework
- 下载并安装 **.NET Framework 4.8**

### Q4: Visual Studio 启动很慢？

**优化**：
1. VS → 工具 → 选项 → 环境 → 启动
2. 选择 **"打开主页"** 而不是 "打开最近的项目"
3. 禁用不必要的扩展（扩展 → 管理扩展）

### Q5: Mac 用户如何配置？

Mac 用户使用 **Visual Studio for Mac**：
1. 下载地址：https://visualstudio.microsoft.com/zh-hans/vs/mac/
2. 安装时选择 **"使用 Unity 的游戏开发"**
3. 其余步骤与 Windows 类似

### Q6: 想用其他代码编辑器？

| 编辑器 | 优点 | 缺点 |
|--------|------|------|
| **Visual Studio** | 功能最全，官方支持 | 较重 |
| **Rider** | 智能提示更强 | 付费（有学生免费版）|
| **VS Code** | 轻量，插件丰富 | 需手动配置 Unity 扩展 |

**VS Code 配置步骤**：
1. 安装 VS Code：https://code.visualstudio.com/
2. 安装扩展：**C#**、**Unity Code Snippets**
3. Unity → Edit → Preferences → External Tools → 选择 Visual Studio Code

---

## 常用快捷键

| 快捷键 | 功能 |
|--------|------|
| **F5** | 调试运行（附加到 Unity）|
| **Ctrl + F5** | 开始执行（不调试）|
| **F9** | 添加/移除断点 |
| **F10** | 单步执行 |
| **F11** | 单步进入 |
| **Ctrl + 空格** | 强制显示智能提示 |
| **Ctrl + .** | 快速修复（显示灯泡）|
| **Ctrl + K, Ctrl + C** | 注释选中代码 |
| **Ctrl + K, Ctrl + U** | 取消注释 |

---

## 下一步

Visual Studio 配置完成后：

1. 📚 阅读 [QUICKSTART.md](QUICKSTART.md) 验证环境
2. 🎮 开始 [完整自学指南](完整自学指南.md)
3. 📝 下载 [学习检查清单](学习检查清单.md)

---

**文档版本**：v1.0  
**最后更新**：2026年4月10日  
**适配**：Visual Studio 2022 / Unity 2021+ / 团结引擎 1.6+
