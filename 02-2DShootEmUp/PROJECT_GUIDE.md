# 🎮 2DShootEmUp - 项目导游图

## 游戏效果

2D 纵向卷轴射击游戏，控制飞船击毁敌人，获得分数。

**核心玩法**：
- 左右移动飞船
- 自动发射子弹
- 击毁敌人得分
- 被敌人撞到扣血

---

## 📁 项目结构

```
02-2DShootEmUp/
├── source/                 # 完整 Unity 项目源码
│   ├── Assets/
│   │   ├── Scripts/       # 所有脚本
│   │   ├── Sprites/       # 图片资源
│   │   ├── Prefabs/       # 预制体
│   │   └── Scenes/        # 场景
│   └── ...
├── demo/                  # 可运行 Demo（Build 好的）
└── docs/                  # 教程文档
```

---

## 🏗️ 系统架构

```
┌─────────────┐     ┌──────────────┐     ┌─────────────┐
│  玩家输入    │────▶│ PlayerController│──▶│   子弹生成   │
└─────────────┘     └──────────────┘     └──────┬──────┘
                                                │
┌─────────────┐     ┌──────────────┐           │
│  敌人生成器  │────▶│ EnemyController│◀─────────┘
└─────────────┘     └──────┬───────┘           │
                           │                   │
                           ▼                   │
                    ┌──────────────┐          │
                    │   碰撞检测    │◀─────────┘
                    └──────┬───────┘
                           │
                           ▼
                    ┌──────────────┐
                    │   分数系统    │
                    └──────────────┘
```

---

## 📖 学习路线

### 第 1 周：理解项目（2 小时）

**任务 1**：运行游戏
1. 打开 `F:\UnityLearning\02-2DShootEmUp\demo\`
2. 运行可执行文件，体验完整游戏
3. 记录你的感受：哪里好玩？哪里可以改进？

**任务 2**：分析项目结构
- Scripts/ 文件夹有哪些脚本？
- 每个脚本是做什么的？
- 它们之间如何交互？

**任务 3**：填写分析表格

| 脚本名 | 挂载对象 | 核心功能 | 关键方法 |
|--------|----------|----------|----------|
| PlayerController | Player | 玩家控制 | Move(), Shoot() |
| EnemySpawner | GameManager | 生成敌人 | SpawnEnemy() |
| Bullet | Bullet 预制体 | 子弹飞行 | OnTriggerEnter2D() |
| GameManager | 空物体 | 游戏管理 | AddScore(), GameOver() |

---

### 第 2 周：复刻核心功能（4 小时）

**目标**：不看源码，自己实现一遍

#### Day 1：玩家移动（1 小时）
1. 新建 2D 项目
2. 创建 Player 对象（Sprite）
3. 编写移动代码：

```csharp
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * moveX * speed * Time.deltaTime;
    }
}
```

**验证标准**：
- [ ] 按 A/D 或左右箭头可以移动
- [ ] 移动平滑，不卡顿
- [ ] 不会移出屏幕边界

#### Day 2：子弹发射（1 小时）
1. 创建 Bullet 预制体
2. 添加发射逻辑：

```csharp
public GameObject bulletPrefab;
public Transform firePoint;
public float fireRate = 0.2f;
private float nextFireTime;

void Update()
{
    if (Input.GetButton("Fire1") && Time.time > nextFireTime)
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        nextFireTime = Time.time + fireRate;
    }
}
```

**验证标准**：
- [ ] 按空格或鼠标发射子弹
- [ ] 有射击间隔，不会连发
- [ ] 子弹向上飞行

#### Day 3：敌人生成（1 小时）
1. 创建 Enemy 预制体
2. 编写生成器：

```csharp
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, spawnRate);
    }
    
    void Spawn()
    {
        float x = Random.Range(-8f, 8f);
        Vector3 pos = new Vector3(x, 6f, 0);
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
```

**验证标准**：
- [ ] 敌人从屏幕上方随机位置生成
- [ ] 敌人向下移动
- [ ] 生成频率可控

#### Day 4：碰撞检测（1 小时）

```csharp
// 子弹脚本
void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Enemy"))
    {
        Destroy(other.gameObject);  // 销毁敌人
        Destroy(gameObject);        // 销毁子弹
        GameManager.Instance.AddScore(10);
    }
}

// 玩家脚本
void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Enemy"))
    {
        GameManager.Instance.TakeDamage(1);
        Destroy(other.gameObject);
    }
}
```

**验证标准**：
- [ ] 子弹击中敌人，两者都消失
- [ ] 敌人撞到玩家，玩家扣血
- [ ] 分数正确增加

---

### 第 3 周：扩展挑战（4 小时）

#### 挑战 1：新武器系统 ⭐
- [ ] **散弹枪**：一次发射 3 发子弹，扇形分布
- [ ] **激光**：持续伤害，穿透敌人
- [ ] **导弹**：追踪最近的敌人

#### 挑战 2：敌人类型 ⭐⭐
- [ ] **快速型**：移动快，血量少
- [ ] **重型**：移动慢，血量厚
- [ ] **射击型**：会发射子弹的敌人

#### 挑战 3：道具系统 ⭐⭐
- [ ] **加血道具**：恢复生命值
- [ ] **护盾道具**：短时间无敌
- [ ] **火力增强**：临时提升射速

#### 挑战 4：Boss 战 ⭐⭐⭐
- [ ] Boss 有多个阶段
- [ ] 不同阶段的攻击模式
- [ ] 血条显示

---

## 🔑 关键技术点

| 技术 | 说明 | 学习重点 |
|------|------|----------|
| 对象池 | 复用子弹对象 | 避免频繁创建销毁 |
| 单例模式 | GameManager | 全局访问游戏状态 |
| 预制体 | Prefab | 动态生成游戏对象 |
| 2D 碰撞 | OnTriggerEnter2D | 触发器碰撞检测 |
| 协程 | IEnumerator | 延时生成敌人 |

---

## ❓ 常见问题

### Q1：子弹发射方向不对？
**检查**：
- 子弹预制体的朝向
- Instantiate 时的 rotation 参数
- 是否使用了 Quaternion.identity

### Q2：敌人不移动？
**检查**：
- Enemy 是否添加了 Rigidbody2D
- 脚本中是否使用了 transform.Translate()
- 游戏是否处于 Play 模式

### Q3：碰撞检测不触发？
**检查**：
- 两个物体都有 Collider2D
- 至少一个勾选了 Is Trigger
- Tag 是否正确设置

---

## 📝 学习检查清单

完成本项目后，你应该能够：

- [ ] 独立创建 2D 项目并配置场景
- [ ] 编写玩家控制脚本（移动、射击）
- [ ] 使用预制体动态生成对象
- [ ] 实现 2D 碰撞检测
- [ ] 设计简单的游戏循环（生成、得分、游戏结束）
- [ ] 添加音效和粒子效果（进阶）

---

**开始时间**：__________  
**完成时间**：__________  
**遇到的困难**：__________