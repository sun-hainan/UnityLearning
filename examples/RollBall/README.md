# 示例项目场景设置指南

## RollBall 场景结构

```
Scene: RollBall
├── Main Camera
│   └── CameraFollow.cs (跟随玩家)
├── Directional Light
├── Ground (Plane)
│   ├── 缩放: (20, 1, 20)
│   └── 材质: Ground.mat
├── Walls (4个Cube组成边界)
│   ├── Wall_North
│   ├── Wall_South
│   ├── Wall_East
│   └── Wall_West
├── Player (Sphere)
│   ├── Transform: (0, 0.5, 0)
│   ├── Rigidbody
│   │   ├── Mass: 1
│   │   ├── Drag: 0
│   │   └── Angular Drag: 0.05
│   └── PlayerController.cs
├── PickUps (父物体)
│   ├── PickUp_1 (Cube)
│   │   ├── Tag: PickUp
│   │   ├── Is Trigger: ✓
│   │   ├── Box Collider
│   │   └── Collectible.cs
│   ├── PickUp_2
│   └── ... (共8-12个)
└── UI
    ├── Canvas
    │   ├── ScoreText (Text)
    │   ├── GameOverPanel (Panel)
    │   └── WinPanel (Panel)
    └── EventSystem
```

## 关键设置

### 1. 玩家 (Player/Sphere)
- **Tag**: Player
- **Layer**: Default
- **Rigidbody**:
  - Use Gravity: ✓
  - Is Kinematic: ☐
  - Constraints: Freeze Position Y (可选)

### 2. 收集物 (PickUp/Cube)
- **Tag**: PickUp
- **Box Collider**:
  - Is Trigger: ✓ (必须勾选)
- **Material**: 黄色自发光

### 3. 相机 (Main Camera)
- **CameraFollow** 组件:
  - Target: Player
  - Offset: (0, 10, -10)
  - Smooth Speed: 0.125

### 4. UI 设置
- **Canvas**:
  - Render Mode: Screen Space - Overlay
- **ScoreText**: 位置 (0, -50), 字号 48

## 测试清单

- [ ] 球可以用方向键控制
- [ ] 球会被墙壁挡住
- [ ] 收集物会旋转和浮动
- [ ] 碰撞收集物后分数+1
- [ ] 收集物消失
- [ ] 相机跟随玩家
- [ ] UI显示正确分数

## 常见问题

**Q: 球不移动？**  
A: 检查 Rigidbody 是否存在，Is Kinematic 是否未勾选

**Q: 收集物不消失？**  
A: 检查 Collider 的 Is Trigger 是否已勾选

**Q: 分数不更新？**  
A: 检查 GameManager 单例是否正确初始化
