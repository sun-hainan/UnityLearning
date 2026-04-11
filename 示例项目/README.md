# Unity 基础示例项目

> 🎮 可直接导入 Unity 的完整示例项目

---

## 项目列表

### 1. RollBall - 滚球游戏
**难度**: ⭐⭐  
**文件**: `RollBall.unitypackage`

包含内容：
- 玩家控制脚本 (PlayerController.cs)
- 相机跟随脚本 (CameraFollow.cs)
- 收集物品系统 (Collectible.cs)
- 计分UI (UIManager.cs)
- 完整场景文件

导入步骤：
1. 下载 `RollBall.unitypackage`
2. Unity → Assets → Import Package → Custom Package
3. 选择下载的文件，点击 Import
4. 打开 Scenes/RollBall 场景
5. 按 Play 运行

---

### 2. FlappyBird - 像素鸟
**难度**: ⭐⭐⭐  
**文件**: `FlappyBird.unitypackage`

包含内容：
- 鸟类控制 (BirdController.cs)
- 管道生成器 (PipeSpawner.cs)
- 碰撞检测 (CollisionHandler.cs)
- 分数系统
- 音效集成

---

### 3. Platformer2D - 2D平台跳跃
**难度**: ⭐⭐⭐⭐  
**文件**: `Platformer2D.unitypackage`

包含内容：
- 角色控制器 (CharacterController2D.cs)
- 动画系统 (AnimatorController)
- 敌人AI (EnemyPatrol.cs)
- 关卡设计示例
- 物理材质配置

---

### 4. FPSController - 第一人称控制
**难度**: ⭐⭐⭐  
**文件**: `FPSController.unitypackage`

包含内容：
- FPS控制器 (FPSController.cs)
- 鼠标视角控制 (MouseLook.cs)
- 跳跃系统
- 脚步声效

---

### 5. UIFramework - UI框架示例
**难度**: ⭐⭐⭐⭐⭐  
**文件**: `UIFramework.unitypackage`

包含内容：
- 场景管理器
- UI面板系统
- 音频管理器
- 数据持久化

---

## 如何使用 .unitypackage

```
Assets
├── Import Package
│   └── Custom Package...
│       └── [选择 .unitypackage 文件]
└── 点击 Import
```

---

## 版本要求

| 项目 | 最低版本 | 推荐版本 |
|-----|---------|---------|
| RollBall | Unity 2021.3 | Unity 2022.3 LTS |
| FlappyBird | Unity 2021.3 | Unity 2022.3 LTS |
| Platformer2D | Unity 2021.3 | Unity 2022.3 LTS |
| FPSController | Unity 2021.3 | Unity 2022.3 LTS |
| UIFramework | Unity 2022.3 | Unity 2022.3 LTS |

> 所有项目均兼容 **团结引擎 1.8.x**

---

## 下载方式

1. **GitHub Releases** - 正式发布版本
2. **百度网盘** - 国内快速下载
3. **直接克隆** - 包含完整项目文件

```bash
git clone https://github.com/sun-hainan/UnityLearning.git
cd UnityLearning/示例项目/
```

---

## 贡献项目

如果你想提交示例项目：

1. 确保代码有中文注释
2. 包含 README 说明
3. 导出为 .unitypackage
4. 提交 Pull Request

---

> 📦 **注意**：.unitypackage 文件较大，GitHub 可能有限制。建议使用 Git LFS 或外部存储。
