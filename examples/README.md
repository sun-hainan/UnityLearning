# Unity 基础示例项目

> 🎮 可直接导入 Unity 的完整示例项目

---

## 项目列表

### 1. RollBall - 滚球游戏
**难度**: ⭐⭐  
**路径**: `RollBall/`

包含内容：
- 玩家控制脚本 (PlayerController.cs)
- 相机跟随脚本 (CameraFollow.cs)
- 收集物品系统 (Collectible.cs)
- 计分UI (UIManager.cs)
- 游戏管理器 (GameManager.cs)
- 场景设置指南 (README.md)

导入步骤：
1. 复制 `RollBall/` 目录到你的项目 Assets 文件夹
2. 按 README 配置场景
3. 运行游戏

---

### 2. FlappyBird - 像素鸟
**难度**: ⭐⭐⭐  
**路径**: `FlappyBird/`

包含内容：
- 鸟类控制 (BirdController.cs)
- 管道生成器 (PipeSpawner.cs)
- 碰撞检测
- 分数系统

---

## 如何使用

### 方式一：直接复制
```
Assets/
├── Scripts/
│   └── [复制 .cs 文件到这里]
```

### 方式二：作为子模块
```bash
git submodule add https://github.com/sun-hainan/UnityLearning.git
```

---

## 版本要求

| 项目 | 最低版本 | 推荐版本 |
|-----|---------|---------|
| RollBall | Unity 2021.3 | Unity 2022.3 LTS |
| FlappyBird | Unity 2021.3 | Unity 2022.3 LTS |

> 所有项目均兼容 **团结引擎 1.8.x**

---

## 贡献项目

如果你想提交示例项目：

1. 确保代码有中文注释
2. 包含 README 说明
3. 提交 Pull Request

---

> 💡 **提示**：每个项目目录都有详细的设置指南！