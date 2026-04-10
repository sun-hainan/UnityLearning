# 🎮 完整可运行示例项目

> 本目录包含可以直接在Unity中运行的完整示例项目。

---

## 📁 示例列表

| 示例名称 | 难度 | 内容 | 预计运行时间 |
|---------|------|------|-------------|
| [Example-01-HelloUnity](#example-01-hellounity) | ⭐ | 最基础的Unity项目 | 5分钟 |
| [Example-02-PlayerMovement](#example-02-playermovement) | ⭐⭐ | 玩家移动控制 | 10分钟 |
| [Example-03-PhysicsDemo](#example-03-physicsdemo) | ⭐⭐ | 物理系统演示 | 10分钟 |
| [Example-04-CollectGame](#example-04-collectgame) | ⭐⭐⭐ | 完整的收集游戏 | 30分钟 |
| [Example-05-2DPlatformer](#example-05-2dplatformer) | ⭐⭐⭐ | 2D平台跳跃游戏 | 1小时 |

---

## Example-01-HelloUnity

### 项目简介
最基础的Unity项目，展示如何创建场景、添加物体、编写脚本。

### 运行步骤

1. 将 `Example-01-HelloUnity` 文件夹复制到你的 Unity 项目目录
2. 在Unity中打开场景 `Scenes/MainScene.unity`
3. 点击 Play 按钮运行

### 场景内容

- 一个立方体（Cube）
- 一个球体（Sphere）
- 地面（Plane）
- 简单的旋转动画脚本

### 学习要点

- 基本场景操作
- 游戏对象和组件
- MonoBehaviour生命周期

---

## Example-02-PlayerMovement

### 项目简介
演示如何实现玩家移动控制，包括键盘输入和物理移动。

### 运行步骤

1. 打开场景 `Scenes/MovementDemo.unity`
2. 点击 Play 运行
3. 使用 **WASD** 或 **方向键** 移动红色方块

### 核心脚本

```csharp
// SimpleMovement.cs
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        // 获取输入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // 移动物体
        transform.position += movement * speed * Time.deltaTime;
    }
}
```

### 扩展练习

- [ ] 添加边界限制，防止玩家走出场景
- [ ] 使用 Rigidbody 实现基于物理的移动
- [ ] 添加跳跃功能（空格键）

---

## Example-03-PhysicsDemo

### 项目简介
演示Unity物理系统的各种功能。

### 运行步骤

1. 打开场景 `Scenes/PhysicsDemo.unity`
2. 点击 Play 运行
3. 观察物体的物理行为

### 场景包含

| 物体 | 说明 |
|------|------|
| 受重力球体 | 展示重力效果 |
| 碰撞立方体 | 展示碰撞检测 |
| 触发区域 | 展示Trigger检测 |
| 弹射板 | 展示AddForce |

### 交互方式

- **左键点击**：发射小球
- **R键**：重置场景

---

## Example-04-CollectGame

### 项目简介
一个完整的收集游戏，玩家控制球体收集场景中的金币。

### 运行步骤

1. 打开场景 `Scenes/CollectGame.unity`
2. 点击 Play 运行
3. 使用 **WASD** 移动球体收集金币
4. 收集所有金币后胜利

### 核心功能

- [x] 玩家移动控制（物理）
- [x] 金币旋转动画
- [x] 碰撞检测收集
- [x] 分数显示（UI）
- [x] 胜利判断

### 项目结构

```
Example-04-CollectGame/
├── Scripts/
│   ├── PlayerController.cs    # 玩家控制
│   ├── Rotator.cs             # 旋转动画
│   ├── Coin.cs                # 金币逻辑
│   ├── GameManager.cs         # 游戏管理
│   └── UIManager.cs           # UI管理
├── Prefabs/
│   ├── Player.prefab
│   ├── Coin.prefab
│   └── Ground.prefab
├── Scenes/
│   └── CollectGame.unity
└── Materials/
    ├── Player.mat
    ├── Coin.mat
    └── Ground.mat
```

### 关键代码解析

**PlayerController.cs**
```csharp
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 获取输入
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // 施加力移动
        Vector3 movement = new Vector3(moveX, 0, moveZ);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // 收集金币
            other.gameObject.SetActive(false);
            score++;
            Debug.Log("Score: " + score);
        }
    }
}
```

---

## Example-05-2DPlatformer

### 项目简介
完整的2D平台跳跃游戏，包含角色动画、物理、关卡设计。

### 运行步骤

1. 打开场景 `Scenes/Level1.unity`
2. 点击 Play 运行
3. **A/D** 或 **方向键** 移动
4. **空格键** 跳跃（支持二段跳）
5. 收集金币，避开敌人

### 核心功能

- [x] 2D角色控制器
- [x] 地面检测系统
- [x] 二段跳
- [x] 角色动画（闲置、跑步、跳跃）
- [x] 敌人巡逻AI
- [x] 金币收集
- [x] 生命值系统
- [x] 关卡重置

### 项目结构

```
Example-05-2DPlatformer/
├── Scripts/
│   ├── PlayerController2D.cs    # 玩家控制器
│   ├── EnemyPatrol.cs           # 敌人巡逻
│   ├── Coin2D.cs                # 金币
│   ├── GroundCheck.cs           # 地面检测
│   ├── CameraFollow.cs          # 相机跟随
│   └── GameManager2D.cs         # 游戏管理
├── Animations/
│   ├── Player/
│   │   ├── Idle.anim
│   │   ├── Run.anim
│   │   └── Jump.anim
│   └── AnimatorControllers/
│       └── Player.controller
├── Sprites/
│   ├── Player/
│   ├── Enemies/
│   ├── Coins/
│   └── Tiles/
├── Prefabs/
│   ├── Player.prefab
│   ├── Enemy.prefab
│   ├── Coin.prefab
│   └── Platform.prefab
└── Scenes/
    └── Level1.unity
```

### 操作说明

| 按键 | 功能 |
|------|------|
| A / ← | 向左移动 |
| D / → | 向右移动 |
| 空格 | 跳跃 |
| R | 重置关卡 |

### 技术要点

1. **Rigidbody2D**：2D物理控制
2. **Ground Check**：使用射线或碰撞器检测地面
3. **Animator**：状态机控制角色动画
4. **Sorting Layer**：管理2D渲染层级

---

## 🚀 如何使用这些示例

### 方式一：直接打开（推荐新手）

1. 将整个 `examples` 文件夹复制到你的 Unity 项目
2. 在 Unity 中逐个打开场景学习
3. 运行并观察效果
4. 修改参数看会发生什么

### 方式二：参考实现（推荐有一定基础）

1. 创建一个新的空项目
2. 查看示例的脚本和场景结构
3. 尝试自己实现相同的功能
4. 对比你的实现和示例的差异

### 方式三：扩展练习（推荐进阶学习）

1. 在示例基础上添加新功能
2. 例如：给收集游戏添加敌人、道具系统
3. 将2D平台跳跃扩展为完整关卡
4. 参考[扩展挑战](#扩展挑战)部分

---

## 🎯 扩展挑战

### Example-04-CollectGame 扩展

- [ ] **添加敌人**：碰到敌人扣血
- [ ] **添加道具**：加速、护盾、磁铁
- [ ] **添加计时器**：限时完成挑战
- [ ] **添加关卡**：多个关卡，难度递增
- [ ] **添加音效**：收集音效、背景音

### Example-05-2DPlatformer 扩展

- [ ] **添加攻击**：按J键攻击敌人
- [ ] **添加血条**：显示玩家生命值
- [ ] **添加存档**：关卡间保存进度
- [ ] **添加Boss战**：关卡末尾的Boss
- [ ] **添加粒子效果**：跳跃尘土、收集闪光

---

## 📚 学习路径建议

```
第1天 → Example-01（熟悉Unity）
第2-3天 → Example-02（掌握移动）
第4-5天 → Example-03（理解物理）
第6-10天 → Example-04（完整项目）
第11-20天 → Example-05（2D进阶）
```

---

## ⚠️ 常见问题

### Q: 场景打不开？

**解决**：确保 Unity 版本兼容（推荐 2022.3 LTS）

### Q: 脚本报错？

**解决**：
1. 检查类名和文件名是否一致
2. 检查是否缺少命名空间引用
3. 查看 Console 窗口的具体错误信息

### Q: 运行后没有反应？

**解决**：
1. 确保脚本挂载到正确的 GameObject
2. 检查 Inspector 中的参数是否设置
3. 确认是否在 Play 模式下

---

## 🔗 相关链接

- [完整自学指南](../完整自学指南.md)
- [学习检查清单](../学习检查清单.md)
- [FAQ](../FAQ.md)

---

**最后更新**：2026年4月10日
