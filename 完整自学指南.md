# Unity + C# 完全自学指南

> 📅 制定日期：2026年4月7日  
> 📁 学习资料位置：`F:\UnityLearning\`  
> 📖 本文档目标：只看本文档和本地仓库即可完整学习，无需外部资料

---

## 目录
1. [准备工作](#一准备工作)
2. [阶段一：Unity入门期（第1-2个月）](#二阶段一unity入门期第1-2个月)
3. [阶段二：第一个项目实践（第3-4个月）](#三阶段二第一个项目实践第3-4个月)
4. [阶段三：进阶系统学习（第5-6个月）](#四阶段三进阶系统学习第5-6个月)
5. [阶段四：高级游戏开发（第7-8个月）](#五阶段四高级游戏开发第7-8个月)
6. [附录：参考代码](#六附录参考代码)

---

## 一、准备工作

### 1.1 安装Unity

**步骤1：下载Unity Hub**
1. 打开浏览器，访问 https://unity.com/download
2. 点击"Download Unity Hub"按钮
3. 下载完成后运行安装程序

**步骤2：安装Unity编辑器**
1. 打开Unity Hub
2. 点击左侧"Installs"标签
3. 点击右上角的"Install Editor"按钮
4. 选择"Unity 2022.3 LTS"版本（长期支持版，最稳定）
5. 勾选以下模块：
   - Microsoft Visual Studio Community（代码编辑器）
   - Android Build Support（如需发布到手机）
   - Documentation（离线文档）
6. 点击"Install"开始安装（约需20-30分钟，视网速而定）

**步骤3：验证安装**
1. 在Unity Hub点击"Projects"标签
2. 点击"New Project"
3. 选择"3D"模板
4. 项目名输入"TestProject"，位置选择桌面
5. 点击"Create Project"
6. 如果能正常打开编辑器，说明安装成功

### 1.2 认识Unity界面

打开Unity后，你会看到5个主要窗口：

| 窗口名称 | 位置 | 功能 |
|---------|------|------|
| **Scene（场景）** | 中间 | 3D/2D编辑视图，像地图编辑器 |
| **Game（游戏）** | Scene旁边 | 游戏运行时的实际画面 |
| **Hierarchy（层级）** | 左侧 | 场景中所有对象的列表 |
| **Inspector（检查器）** | 右侧 | 显示选中对象的属性 |
| **Project（项目）** | 底部 | 项目中的所有文件资源 |
| **Console（控制台）** | Project旁边 | 显示错误、警告、日志 |

**常用操作：**
- **旋转视图**：按住鼠标右键拖动
- **平移视图**：按住鼠标中键拖动
- **缩放视图**：滚动鼠标滚轮
- **选中物体**：左键单击
- **移动物体**：选中后按W键，拖动箭头

### 1.3 学习资料准备

确保以下文件夹存在：
```
F:\UnityLearning\
├── 01-AwesomeUnityTutorial\    (中文系统教程)
├── 02-2DShootEmUp\             (2D射击游戏)
├── 03-RTS-Strategy\            (RTS策略游戏)
├── 04-HacknSlash\              (动作RPG游戏)
├── 学习计划.md
├── 每日任务清单.md
└── 快速参考指南.md
```

---

## 二、阶段一：Unity入门期（第1-2个月）

**目标**：掌握Unity基本操作和C#基础语法，能独立创建简单项目

---

### 第1周：Unity界面和基础操作

**本周目标**：熟悉Unity编辑器，理解场景、游戏对象、组件的概念

#### Day 1：创建第一个项目

**任务1：新建项目**
1. 打开Unity Hub
2. 点击"New Project" → "3D"
3. 项目名称："Week1_Learning"
4. 位置：F:\UnityLearning\Projects\
5. 点击"Create Project"

**任务2：认识Scene窗口**
- 试着用鼠标右键旋转视角
- 用滚轮缩放
- 用中键平移
- 找到Scene窗口上方的工具栏：手型、箭头、旋转、缩放

**任务3：创建第一个游戏对象**
1. 在Hierarchy窗口右键 → "3D Object" → "Cube"
2. 观察Inspector窗口出现了什么
3. 在Scene窗口点击Cube，看它被选中（有橙色边框）
4. 按W键，出现移动箭头，试着拖动Cube

#### Day 2：理解组件系统

**核心概念**：Unity使用**组件（Component）**来构建游戏对象。一个游戏对象就像乐高积木，由多个组件拼装而成。

**任务1：查看Cube的组件**
选中Cube，看Inspector窗口：
- **Transform**：位置、旋转、缩放
- **Mesh Filter**：决定形状
- **Mesh Renderer**：决定如何渲染（显示）
- **Box Collider**：碰撞检测

**任务2：添加新组件**
1. 选中Cube
2. Inspector底部点击"Add Component"
3. 搜索"Rigidbody"并添加
4. 点击Play按钮（顶部中间的▶️）
5. 观察：Cube受重力影响掉下去了！
6. 再点Play停止

**任务3：理解Transform**
选中Cube，看Transform组件的三个值：
- **Position（位置）**：X=0, Y=0, Z=0 表示在原点
- **Rotation（旋转）**：X=0, Y=0, Z=0 表示没有旋转
- **Scale（缩放）**：X=1, Y=1, Z=1 表示原始大小

试着修改这些值，看Cube如何变化。

#### Day 3：预制体（Prefab）

**核心概念**：预制体是可重复使用的游戏对象模板。

**任务1：创建预制体**
1. 在Hierarchy中创建一个Cube（右键→3D Object→Cube）
2. 改名为"MyCube"
3. 在Project窗口创建文件夹"Prefabs"
4. 把MyCube从Hierarchy拖到Prefabs文件夹
5. 观察：Hierarchy中的MyCube变成蓝色，表示它是预制体的实例

**任务2：使用预制体**
1. 从Prefabs文件夹拖一个MyCube到Hierarchy
2. 现在有2个Cube了
3. 修改Prefab：双击Prefabs中的MyCube，修改颜色
4. 保存（Ctrl+S），返回场景
5. 观察：两个Cube都变色了！

#### Day 4：光照和相机

**任务1：理解Camera**
1. 选中Main Camera
2. 看Inspector中的Camera组件
3. 在Scene窗口移动Camera，看Game窗口的变化
4. **关键理解**：Camera决定了玩家看到什么

**任务2：理解Light**
1. 选中Directional Light（平行光，模拟太阳）
2. 旋转它，观察场景中阴影的变化
3. 右键→Light→Point Light，创建一个点光源
4. 移动点光源，观察效果

#### Day 5-7：实践练习

**综合练习：搭建简单房间**

目标：用Cube搭建一个有地板、四面墙、天花板的简单房间

**步骤**：
1. 创建Floor（地板）：
   - 右键→3D Object→Cube
   - 命名"Floor"
   - Transform：Position(0,0,0), Scale(10,0.1,10)

2. 创建Walls（四面墙）：
   - 创建4个Cube
   - 分别命名为Wall1, Wall2, Wall3, Wall4
   - 调整位置和大小，围成房间

3. 添加光源：
   - 调整Directional Light角度，让房间有自然光照
   - 添加Point Light作为室内灯

4. 添加一个球体作为"玩家"：
   - 右键→3D Object→Sphere
   - 命名为"Player"
   - 添加Rigidbody组件

5. 点击Play测试：
   - 球应该掉落在地板上
   - 可以在Scene窗口推动球

---

### 第2周：C#编程基础

**本周目标**：掌握C#基础语法，能写简单的脚本

#### Day 1：创建第一个脚本

**任务1：创建脚本文件**
1. Project窗口创建文件夹"Scripts"
2. 右键→Create→C# Script，命名为"HelloWorld"
3. 双击脚本，自动打开Visual Studio

**任务2：认识脚本结构**
```csharp
using UnityEngine;  // 引入Unity引擎的功能

// 类名必须和文件名一致
public class HelloWorld : MonoBehaviour
{
    // Start在脚本启动时执行一次
    void Start()
    {
        // Debug.Log在控制台打印消息
        Debug.Log("Hello, Unity!");
    }

    // Update每帧执行一次（每秒约60次）
    void Update()
    {
        
    }
}
```

**任务3：运行脚本**
1. 保存脚本（Ctrl+S）
2. 回到Unity
3. 把脚本拖到Hierarchy的任意对象上（如Main Camera）
4. 点击Play
5. 看Console窗口，应该显示"Hello, Unity!"

#### Day 2：变量和数据类型

**核心概念**：变量是存储数据的容器

**C#常用数据类型**：
| 类型 | 说明 | 示例 |
|------|------|------|
| `int` | 整数 | `int age = 25;` |
| `float` | 小数（必须加f） | `float speed = 5.5f;` |
| `bool` | 布尔（真/假） | `bool isAlive = true;` |
| `string` | 字符串 | `string name = "Player";` |
| `Vector3` | 三维向量（Unity特有） | `Vector3 pos = new Vector3(0,1,0);` |

**练习脚本**：
```csharp
using UnityEngine;

public class VariablesDemo : MonoBehaviour
{
    // 公开变量可以在Inspector中修改
    public int playerHealth = 100;
    public float moveSpeed = 5.0f;
    public string playerName = "Hero";
    
    // 私有变量只能在代码中使用
    private int score = 0;

    void Start()
    {
        Debug.Log("玩家名字：" + playerName);
        Debug.Log("初始生命值：" + playerHealth);
    }

    void Update()
    {
        // 按空格键增加分数
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 10;
            Debug.Log("当前分数：" + score);
        }
    }
}
```

**任务**：
1. 创建这个脚本
2. 挂到Cube上
3. 在Inspector中修改playerName的值
4. 运行游戏，按空格键看效果

#### Day 3：条件语句（if/else）

**核心概念**：根据条件执行不同代码

**基本语法**：
```csharp
if (条件)
{
    // 条件为真时执行
}
else
{
    // 条件为假时执行
}
```

**比较运算符**：
- `==` 等于
- `!=` 不等于
- `>` 大于
- `<` 小于
- `>=` 大于等于
- `<=` 小于等于

**逻辑运算符**：
- `&&` 并且
- `||` 或者
- `!` 非（取反）

**练习脚本：生命值检测**：
```csharp
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        // 按H键扣血
        if (Input.GetKeyDown(KeyCode.H))
        {
            health = health - 10;
            Debug.Log("受到伤害！当前生命值：" + health);
            
            // 检测死亡
            if (health <= 0)
            {
                Debug.Log("游戏结束！");
            }
            else if (health <= 30)
            {
                Debug.Log("警告：生命值过低！");
            }
        }
        
        // 按R键回血
        if (Input.GetKeyDown(KeyCode.R))
        {
            health = 100;
            Debug.Log("生命值恢复！");
        }
    }
}
```

#### Day 4：循环语句

**for循环**：执行固定次数
```csharp
// 打印0到4
for (int i = 0; i < 5; i++)
{
    Debug.Log("循环次数：" + i);
}
```

**while循环**：条件满足时持续执行
```csharp
// 危险！可能导致无限循环
while (health > 0)
{
    health--;  // 扣1点血
}
```

**foreach循环**：遍历集合（后面学数组时用）

#### Day 5：方法和函数

**核心概念**：把代码块封装成可重复调用的功能

**基本语法**：
```csharp
// 返回值类型 方法名(参数) { 方法体 }

// 无返回值，无参数
void SayHello()
{
    Debug.Log("Hello!");
}

// 有返回值，有参数
int Add(int a, int b)
{
    return a + b;  // return返回结果
}

// 使用
void Start()
{
    SayHello();           // 输出Hello!
    int result = Add(3, 5);  // result = 8
}
```

**练习：创建一个完整的玩家控制脚本**

```csharp
using UnityEngine;

public class SimplePlayer : MonoBehaviour
{
    public float speed = 5f;
    public int health = 100;
    
    void Update()
    {
        // 获取输入
        float h = Input.GetAxis("Horizontal");  // A/D或左右箭头
        float v = Input.GetAxis("Vertical");    // W/S或上下箭头
        
        // 移动
        Move(h, v);
        
        // 检测受伤
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }
    
    void Move(float horizontal, float vertical)
    {
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // 移动物体
        transform.position += movement * speed * Time.deltaTime;
    }
    
    void TakeDamage(int damage)
    {
        health -= damage;  // 等同于 health = health - damage
        Debug.Log("受到伤害！剩余生命：" + health);
        
        if (health <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Debug.Log("玩家死亡！");
        Destroy(gameObject);  // 销毁自己
    }
}
```

**任务**：
1. 创建脚本并挂到Cube上
2. 运行游戏
3. 用WASD移动Cube
4. 按空格键模拟受伤

#### Day 6-7：综合练习

**练习项目：简单的收集游戏**

**目标**：控制一个球体，收集场景中的金币

**步骤1：创建玩家**
1. 创建Sphere，命名为"Player"
2. 添加Rigidbody组件
3. 冻结Rigidbody的Rotation（防止滚动失控）
4. 创建脚本"PlayerController"：

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()  // 物理更新用FixedUpdate
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }

    // 触发器检测
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);  // 隐藏金币
            score = score + 1;
            Debug.Log("得分：" + score);
        }
    }
}
```

**步骤2：创建金币**
1. 创建Cube，命名为"PickUp"
2. 缩小到0.5, 0.5, 0.5
3. 旋转45度（让它是菱形）
4. 添加Rigidbody，勾选Is Kinematic（不受物理影响）
5. 勾选Box Collider的Is Trigger（变成触发器）
6. 创建Tag"PickUp"并赋给它
7. 拖到Project窗口做成Prefab
8. 复制多个放到场景中

**步骤3：添加旋转动画**
创建脚本"Rotator"：
```csharp
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
```
挂到PickUp预制体上

**步骤4：测试游戏**
- 运行游戏
- 用WASD控制球体移动
- 碰到金币时金币消失，控制台显示得分

---

### 第3-4周：Unity核心组件详解

**本周目标**：深入理解Transform、物理系统、输入系统

#### Transform组件深入

**核心属性**：
```csharp
// 获取位置
Vector3 pos = transform.position;  // 世界坐标
Vector3 localPos = transform.localPosition;  // 相对于父物体的坐标

// 设置位置
transform.position = new Vector3(0, 5, 0);
transform.position += Vector3.up * 2;  // 向上移动2个单位

// 获取旋转
transform.rotation;  // Quaternion（四元数）
transform.eulerAngles;  // 欧拉角（0-360度）

// 获取缩放
transform.localScale;
```

**常用方法**：
```csharp
// 向某个方向移动
transform.Translate(Vector3.forward * Time.deltaTime);

// 旋转
transform.Rotate(Vector3.up * 100 * Time.deltaTime);

// 看向某个物体
transform.LookAt(targetTransform);

// 获取前方/右方/上方方向
Vector3 forward = transform.forward;
Vector3 right = transform.right;
Vector3 up = transform.up;
```

#### 物理系统详解

**Rigidbody（刚体）属性**：
| 属性 | 说明 |
|------|------|
| Mass | 质量 |
| Drag | 阻力（空气阻力） |
| Angular Drag | 旋转阻力 |
| Use Gravity | 是否受重力影响 |
| Is Kinematic | 是否受物理控制（false=受物理控制） |

**常用方法**：
```csharp
Rigidbody rb = GetComponent<Rigidbody>();

// 添加力
rb.AddForce(Vector3.up * 500);  // 向上跳
rb.AddForce(Vector3.forward * 1000, ForceMode.Impulse);  // 爆发力

// 添加扭矩（旋转力）
rb.AddTorque(Vector3.up * 100);

// 直接设置速度
rb.velocity = new Vector3(0, 10, 0);

// 移动位置（物理友好）
rb.MovePosition(newPosition);
```

**碰撞检测**：
```csharp
// 碰撞器碰撞（两个物体都有Collider，至少一个有Rigidbody）
void OnCollisionEnter(Collision collision)
{
    Debug.Log("撞到了：" + collision.gameObject.name);
}

void OnCollisionStay(Collision collision) { }  // 持续碰撞中
void OnCollisionExit(Collision collision) { }   // 碰撞结束

// 触发器碰撞（至少一个勾选了Is Trigger）
void OnTriggerEnter(Collider other)
{
    Debug.Log("触发：" + other.gameObject.name);
}
```

#### 输入系统

**传统Input系统**：
```csharp
// 按键检测
bool isDown = Input.GetKey(KeyCode.Space);        // 按住
bool isPressed = Input.GetKeyDown(KeyCode.Space); // 按下瞬间
bool isReleased = Input.GetKeyUp(KeyCode.Space);  // 松开瞬间

// 轴输入（平滑，-1到1）
float horizontal = Input.GetAxis("Horizontal");  // A/D或左右箭头
float vertical = Input.GetAxis("Vertical");      // W/S或上下箭头

// 鼠标输入
float mouseX = Input.GetAxis("Mouse X");
float mouseY = Input.GetAxis("Mouse Y");
bool mouseDown = Input.GetMouseButton(0);  // 0=左键, 1=右键, 2=中键
```

---

### 第5-6周：2D游戏基础

**本周目标**：掌握Unity 2D开发

#### 2D vs 3D的区别

**创建2D项目**：
1. New Project时选择"2D (URP)"模板
2. 或者在3D项目中：
   - Edit → Project Settings → Graphics
   - 将渲染管线改为2D

**核心概念**：
- Sprite：2D图片，相当于3D中的Mesh
- Sprite Renderer：渲染Sprite的组件
- Rigidbody2D：2D刚体
- Collider2D：2D碰撞器（BoxCollider2D, CircleCollider2D等）

#### Sprite（精灵）

**导入图片**：
1. 把图片拖到Project窗口
2. 选中图片，Inspector中：
   - Texture Type：Sprite (2D and UI)
   - 点击Apply

**使用Sprite**：
1. Hierarchy右键 → 2D Object → Sprites → Square
2. 或者拖拽Sprite到场景

**Sprite Renderer组件**：
- Sprite：要显示的图片
- Color：颜色叠加
- Flip X/Y：水平/垂直翻转
- Sorting Layer：渲染层级
- Order in Layer：同层级内的顺序

#### 2D物理

**Rigidbody2D属性**：
| 属性 | 说明 |
|------|------|
| Body Type | Dynamic(动态), Kinematic(运动学), Static(静态) |
| Mass | 质量 |
| Gravity Scale | 重力缩放（0=无重力） |
| Constraints | 冻结位置/旋转 |

**常用2D碰撞器**：
- BoxCollider2D：矩形
- CircleCollider2D：圆形
- PolygonCollider2D：多边形（自动根据Sprite生成）

**2D碰撞检测**：
```csharp
void OnCollisionEnter2D(Collision2D collision) { }
void OnTriggerEnter2D(Collider2D other) { }
```

#### 2D动画

**创建动画步骤**：
1. 选中带Sprite Renderer的游戏对象
2. Window → Animation → Animation（打开动画窗口）
3. 点击Create，保存动画文件
4. 把多张Sprite拖到时间轴上
5. 调整每帧时长

**动画控制代码**：
```csharp
Animator animator = GetComponent<Animator>();

// 设置参数
animator.SetFloat("Speed", Mathf.Abs(horizontal));
animator.SetBool("IsGrounded", isGrounded);
animator.SetTrigger("Jump");

// 播放指定动画
animator.Play("Run");
```

---

### 第7-8周：阶段一综合项目

**项目名称**：2D平台跳跃游戏

**核心功能**：
1. 角色左右移动
2. 跳跃（可二段跳）
3. 地面检测
4. 收集金币
5. 敌人（碰到扣血）
6. 生命值系统
7. 关卡重置

**完整代码示例**：

```csharp
// PlayerController2D.cs
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    [Header("移动")]
    public float moveSpeed = 5f;
    
    [Header("跳跃")]
    public float jumpForce = 10f;
    public int maxJumps = 2;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    
    [Header("生命")]
    public int maxHealth = 3;
    private int currentHealth;
    
    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private int jumpsRemaining;
    private bool facingRight = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
        jumpsRemaining = maxJumps;
    }
    
    void Update()
    {
        // 地面检测
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        if (isGrounded)
        {
            jumpsRemaining = maxJumps;
        }
        
        // 跳跃
        if (Input.GetButtonDown("Jump") && jumpsRemaining > 0)
        {
            Jump();
        }
        
        // 更新动画
        if (animator != null)
        {
            animator.SetBool("IsGrounded", isGrounded);
            animator.SetFloat("VerticalVelocity", rb.velocity.y);
        }
    }
    
    void FixedUpdate()
    {
        // 移动
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
        
        // 翻转角色
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
        
        // 更新动画
        if (animator != null)
        {
            animator.SetFloat("Speed", Mathf.Abs(move));
        }
    }
    
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        jumpsRemaining--;
        
        if (animator != null)
        {
            animator.SetTrigger("Jump");
        }
    }
    
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("受到伤害！剩余生命：" + currentHealth);
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Debug.Log("游戏结束！");
        // 重新加载场景
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("获得金币！");
        }
        else if (other.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
    
    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
```

**项目结构**：
```
Assets/
├── Scripts/
│   ├── PlayerController2D.cs
│   ├── Coin.cs
│   ├── Enemy.cs
│   └── GameManager.cs
├── Sprites/
│   ├── Player/
│   ├── Tileset/
│   └── Items/
├── Animations/
│   ├── Player/
│   └── Coins/
├── Prefabs/
│   ├── Player.prefab
│   ├── Coin.prefab
│   └── Enemy.prefab
└── Scenes/
    └── Level1.unity
```

---

## 三、阶段二：第一个项目实践（第3-4个月）

**目标**：完整阅读并复刻02-2DShootEmUp项目，理解完整游戏开发流程

---

### 第1-2周：项目分析

**任务1：运行游戏**
1. 打开 `F:\UnityLearning\02-2DShootEmUp\`
2. 在Unity中打开项目
3. 找到主场景（通常是MainScene或GameScene）
4. 点击Play运行，体验完整游戏

**任务2：绘制游戏流程图**
在纸上或画图工具中画出：
```
[开始] → [生成玩家] → [生成敌人] → [玩家射击] → [击中敌人？]
                                           ↓
                                   [是] → [敌人死亡+加分]
                                   [否] → [继续]
                                           ↓
                              [玩家被击中？] → [扣血/游戏结束]
```

**任务3：分析项目结构**
按文件夹逐个分析：
- Scripts/：有哪些脚本？每个脚本是做什么的？
- Prefabs/：有哪些预制体？
- Sprites/：图片资源
- Scenes/：场景文件

**任务4：填写分析表格**

| 脚本名 | 挂载对象 | 核心功能 | 关键方法 |
|--------|---------|---------|---------|
| PlayerController | Player | 玩家控制 | Move(), Shoot() |
| EnemyController | Enemy | 敌人AI | ... |
| GameManager | 空物体 | 游戏管理 | ... |
| ... | ... | ... | ... |

---

### 第3-4周：代码精读

**阅读顺序建议**：
1. 从最简单的脚本开始（如Rotator.cs）
2. 再看玩家控制
3. 然后看敌人AI
4. 最后看游戏管理器

**阅读方法**：
1. 先看类声明和变量（了解这个类有什么）
2. 再看Start()和Awake()（初始化逻辑）
3. 再看Update()和FixedUpdate()（主逻辑）
4. 最后看其他方法

**示例分析：PlayerController.cs**

```csharp
// 假设这是项目中的PlayerController脚本
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ========== 变量区 ==========
    [Header("移动设置")]
    public float speed = 5f;           // 移动速度
    public float xBoundary = 8f;       // 边界限制
    
    [Header("射击设置")]
    public GameObject bulletPrefab;    // 子弹预制体
    public Transform firePoint;        // 发射点
    public float fireRate = 0.2f;      // 射击间隔
    
    private float nextFireTime;        // 下次可射击时间
    private Rigidbody2D rb;
    private Animator animator;
    
    // ========== 生命周期 ==========
    void Awake()
    {
        // 获取组件引用
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // 处理输入（每帧）
        HandleInput();
    }
    
    void FixedUpdate()
    {
        // 处理物理（固定时间间隔）
        Move();
    }
    
    // ========== 方法区 ==========
    void HandleInput()
    {
        // 射击
        if (Input.GetButton("Fire1") && Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }
    
    void Move()
    {
        // 获取水平输入
        float moveX = Input.GetAxis("Horizontal");
        
        // 计算新位置
        Vector3 newPosition = transform.position + Vector3.right * moveX * speed * Time.fixedDeltaTime;
        
        // 限制在边界内
        newPosition.x = Mathf.Clamp(newPosition.x, -xBoundary, xBoundary);
        
        // 应用位置
        rb.MovePosition(newPosition);
        
        // 更新动画
        if (animator != null)
        {
            animator.SetFloat("MoveX", Mathf.Abs(moveX));
        }
    }
    
    void Shoot()
    {
        // 实例化子弹
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // 播放音效（如果有）
        // AudioManager.Instance.PlayShootSound();
    }
    
    // ========== 碰撞检测 ==========
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
        {
            // 受伤
            GameManager.Instance.PlayerTakeDamage(1);
            
            // 销毁敌人子弹
            if (other.CompareTag("EnemyBullet"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
```

**分析方法**：
1. 变量区：了解有哪些可配置参数
2. 生命周期：了解初始化和更新逻辑
3. 方法区：了解功能如何拆分
4. 碰撞检测：了解交互逻辑

---

### 第5-6周：模仿开发

**目标**：不看原代码，凭记忆和理解重新做一遍

**步骤1：新建项目**
1. 创建新项目"MyShootEmUp"
2. 设置为2D项目
3. 创建文件夹结构

**步骤2：导入资源**
1. 从原项目中复制需要的Sprite到项目
2. 或者自己用简单图形代替（方块、圆形）

**步骤3：逐个功能实现**
按优先级顺序：
1. 玩家移动（能左右移动就行）
2. 玩家射击（能发射子弹就行）
3. 敌人生成（能出现敌人就行）
4. 子弹击中敌人（能打中就行）
5. 敌人移动（敌人能动就行）
6. 玩家受伤（能扣血就行）
7. 分数系统
8. 游戏结束和重新开始

**每个功能的开发流程**：
```
1. 写脚本 → 2. 挂到对象上 → 3. 测试 → 4. 调试 → 5. 完善
```

---

### 第7-8周：自主修改

**必做扩展（至少3个）**：

1. **新武器系统**
   - 散弹枪：一次发射多发子弹
   - 激光：持续伤害
   - 导弹：追踪敌人

2. **敌人类型**
   - 快速但血量少的敌人
   - 慢速但血量厚的敌人
   - 会发射子弹的敌人

3. **道具系统**
   - 加血道具
   - 加速道具
   - 护盾道具

4. **关卡系统**
   - 多波敌人
   - Boss战
   - 难度递增

5. **视觉特效**
   - 爆炸粒子效果
   - 屏幕震动
   - 伤害闪烁

**扩展功能实现示例**：

```csharp
// WeaponSystem.cs - 武器切换
using UnityEngine;

public enum WeaponType { Single, Spread, Laser }

public class WeaponSystem : MonoBehaviour
{
    public WeaponType currentWeapon = WeaponType.Single;
    
    public void Shoot()
    {
        switch (currentWeapon)
        {
            case WeaponType.Single:
                ShootSingle();
                break;
            case WeaponType.Spread:
                ShootSpread();
                break;
            case WeaponType.Laser:
                ShootLaser();
                break;
        }
    }
    
    void ShootSingle()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
    
    void ShootSpread()
    {
        // 发射3发子弹，角度不同
        for (int i = -1; i <= 1; i++)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, i * 15);
            Instantiate(bulletPrefab, firePoint.position, rotation);
        }
    }
    
    void ShootLaser()
    {
        // 射线检测
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, Vector2.up);
        if (hit.collider != null)
        {
            // 对击中的敌人造成伤害
        }
        
        // 绘制激光线
        Debug.DrawLine(firePoint.position, firePoint.position + Vector3.up * 10, Color.red, 0.1f);
    }
    
    public void ChangeWeapon(WeaponType newWeapon)
    {
        currentWeapon = newWeapon;
    }
}
```

---

## 四、阶段三：进阶系统学习（第5-6个月）

**目标**：学习03-RTS-Strategy项目，掌握复杂游戏系统架构

---

### 核心概念：游戏架构设计

#### 1. 单例模式（Singleton）

**用途**：确保一个类只有一个实例，全局可访问

**代码实现**：
```csharp
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // 切换场景不销毁
        }
        else
        {
            Destroy(gameObject);  // 已存在则销毁重复的
        }
    }
}
```

**使用场景**：
- GameManager（游戏管理）
- AudioManager（音频管理）
- UIManager（UI管理）
- SaveManager（存档管理）

#### 2. ScriptableObjects

**用途**：存储不依赖于场景的数据，如物品配置、敌人属性

**创建SO**：
```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "RTS/Unit")]
public class UnitData : ScriptableObject
{
    public string unitName;
    public int health;
    public int attack;
    public float moveSpeed;
    public Sprite icon;
    public GameObject prefab;
    public int cost;  // 生产花费
    public float buildTime;  // 生产时间
}
```

**创建SO文件**：
- Project窗口右键 → Create → RTS → Unit
- 填写数据并保存

**使用SO**：
```csharp
public class Unit : MonoBehaviour
{
    public UnitData data;  // 在Inspector中拖入SO
    
    void Start()
    {
        // 使用SO中的数据
        GetComponent<SpriteRenderer>().sprite = data.icon;
        health = data.health;
    }
}
```

#### 3. 事件系统（Event System）

**用途**：解耦系统间的依赖，如敌人死亡时通知UI更新分数

**实现**：
```csharp
// EventManager.cs
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }
    
    void Awake()
    {
        Instance = this;
    }
    
    // 定义事件
    public event Action<int> OnScoreChanged;
    public event Action OnGameOver;
    public event Action<Unit> OnUnitSelected;
    
    // 触发事件的方法
    public void ScoreChanged(int newScore)
    {
        OnScoreChanged?.Invoke(newScore);
    }
    
    public void GameOver()
    {
        OnGameOver?.Invoke();
    }
    
    public void UnitSelected(Unit unit)
    {
        OnUnitSelected?.Invoke(unit);
    }
}
```

**订阅事件**：
```csharp
// UIManager.cs
void OnEnable()
{
    EventManager.Instance.OnScoreChanged += UpdateScoreUI;
    EventManager.Instance.OnGameOver += ShowGameOverScreen;
}

void OnDisable()
{
    EventManager.Instance.OnScoreChanged -= UpdateScoreUI;
    EventManager.Instance.OnGameOver -= ShowGameOverScreen;
}

void UpdateScoreUI(int score)
{
    scoreText.text = "Score: " + score;
}
```

**触发事件**：
```csharp
// Enemy.cs
void OnDeath()
{
    EventManager.Instance.ScoreChanged(100);
    Destroy(gameObject);
}
```

---

### 系统模块学习

#### 模块1：RTS建筑放置系统

**核心功能**：
1. 点击UI按钮选择建筑类型
2. 鼠标移动时显示建筑预览（半透明）
3. 点击地面放置建筑
4. 检测放置位置是否合法（不重叠、在可建造区域）

**代码结构**：
```csharp
// BuildingManager.cs
public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set; }
    
    [Header("建筑预制体")]
    public BuildingData[] availableBuildings;
    
    [Header("预览")]
    public Material previewMaterialValid;
    public Material previewMaterialInvalid;
    
    private BuildingData selectedBuilding;
    private GameObject previewObject;
    private bool isPlacing = false;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        if (isPlacing)
        {
            UpdatePreview();
            
            if (Input.GetMouseButtonDown(0) && IsValidPlacement())
            {
                PlaceBuilding();
            }
            
            if (Input.GetMouseButtonDown(1))
            {
                CancelPlacement();
            }
        }
    }
    
    public void SelectBuilding(int index)
    {
        selectedBuilding = availableBuildings[index];
        StartPlacement();
    }
    
    void StartPlacement()
    {
        isPlacing = true;
        
        // 创建预览对象
        previewObject = Instantiate(selectedBuilding.prefab);
        
        // 禁用碰撞器，只保留视觉效果
        foreach (var collider in previewObject.GetComponentsInChildren<Collider>())
        {
            collider.enabled = false;
        }
        
        // 设置半透明材质
        SetPreviewMaterial(previewMaterialValid);
    }
    
    void UpdatePreview()
    {
        // 射线检测获取鼠标位置
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, buildableLayer))
        {
            previewObject.transform.position = hit.point;
            
            // 检查位置是否合法
            bool isValid = IsValidPlacement();
            SetPreviewMaterial(isValid ? previewMaterialValid : previewMaterialInvalid);
        }
    }
    
    bool IsValidPlacement()
    {
        // 检测是否有其他建筑重叠
        Collider[] colliders = Physics.OverlapBox(
            previewObject.transform.position, 
            previewObject.transform.localScale / 2);
        
        return colliders.Length == 0;  // 没有碰撞即为合法
    }
    
    void PlaceBuilding()
    {
        // 扣除资源
        if (!ResourceManager.Instance.CanAfford(selectedBuilding.cost))
        {
            Debug.Log("资源不足！");
            return;
        }
        
        ResourceManager.Instance.SpendResources(selectedBuilding.cost);
        
        // 实例化真实建筑
        Instantiate(selectedBuilding.prefab, previewObject.transform.position, Quaternion.identity);
        
        // 销毁预览
        Destroy(previewObject);
        isPlacing = false;
    }
    
    void CancelPlacement()
    {
        Destroy(previewObject);
        isPlacing = false;
    }
    
    void SetPreviewMaterial(Material mat)
    {
        foreach (var renderer in previewObject.GetComponentsInChildren<Renderer>())
        {
            renderer.material = mat;
        }
    }
}
```

#### 模块2：存档系统

**JSON存档**：
```csharp
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int score;
    public int level;
    public float[] playerPosition;
    public string[] unlockedLevels;
}

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; private set; }
    
    private string savePath;
    
    void Awake()
    {
        Instance = this;
        savePath = Application.persistentDataPath + "/save.json";
    }
    
    public void SaveGame()
    {
        SaveData data = new SaveData();
        data.score = GameManager.Instance.score;
        data.level = GameManager.Instance.currentLevel;
        
        Vector3 pos = PlayerController.Instance.transform.position;
        data.playerPosition = new float[] { pos.x, pos.y, pos.z };
        
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);
        
        Debug.Log("游戏已保存到：" + savePath);
    }
    
    public void LoadGame()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            
            GameManager.Instance.score = data.score;
            GameManager.Instance.currentLevel = data.level;
            
            Vector3 pos = new Vector3(
                data.playerPosition[0],
                data.playerPosition[1],
                data.playerPosition[2]);
            PlayerController.Instance.transform.position = pos;
            
            Debug.Log("游戏已加载");
        }
        else
        {
            Debug.Log("没有找到存档文件");
        }
    }
}
```

---

## 五、阶段四：高级游戏开发（第7-8个月）

**目标**：学习04-HacknSlash项目，掌握动作游戏核心机制

---

### 核心概念

#### 1. 有限状态机（Finite State Machine, FSM）

**用途**：管理AI或玩家的不同状态（闲置、移动、攻击、受伤、死亡）

**基本实现**：
```csharp
// 定义状态
public enum EnemyState { Idle, Patrol, Chase, Attack, Hurt, Die }

public class EnemyFSM : MonoBehaviour
{
    public EnemyState currentState;
    
    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                IdleUpdate();
                break;
            case EnemyState.Patrol:
                PatrolUpdate();
                break;
            case EnemyState.Chase:
                ChaseUpdate();
                break;
            case EnemyState.Attack:
                AttackUpdate();
                break;
        }
    }
    
    void IdleUpdate()
    {
        // 检测玩家
        if (CanSeePlayer())
        {
            ChangeState(EnemyState.Chase);
        }
        
        // 随机切换到巡逻
        if (Time.time > nextPatrolTime)
        {
            ChangeState(EnemyState.Patrol);
        }
    }
    
    void ChaseUpdate()
    {
        // 向玩家移动
        MoveTowards(player.position);
        
        // 距离足够近则攻击
        if (DistanceTo(player) <= attackRange)
        {
            ChangeState(EnemyState.Attack);
        }
        
        // 丢失目标则回到闲置
        if (!CanSeePlayer())
        {
            ChangeState(EnemyState.Idle);
        }
    }
    
    void ChangeState(EnemyState newState)
    {
        // 退出当前状态
        OnExitState(currentState);
        
        // 切换状态
        currentState = newState;
        
        // 进入新状态
        OnEnterState(newState);
    }
    
    void OnEnterState(EnemyState state)
    {
        switch (state)
        {
            case EnemyState.Attack:
                animator.SetTrigger("Attack");
                attackTimer = 0;
                break;
            case EnemyState.Die:
                animator.SetTrigger("Die");
                GetComponent<Collider>().enabled = false;
                break;
        }
    }
}
```

#### 2. 连招系统

**实现思路**：
```csharp
public class ComboSystem : MonoBehaviour
{
    [System.Serializable]
    public class ComboStage
    {
        public string animationName;
        public float damage;
        public float duration;
        public float inputWindowStart;  // 可输入下一招的起始时间
        public float inputWindowEnd;    // 可输入下一招的结束时间
    }
    
    public ComboStage[] comboStages;
    public float comboResetTime = 2f;  // 多久不按重置连招
    
    private int currentComboIndex = 0;
    private float lastAttackTime;
    private bool isAttacking = false;
    private Animator animator;
    
    void Update()
    {
        if (isAttacking)
        {
            // 检查是否在输入窗口内
            float currentTime = Time.time - lastAttackTime;
            var stage = comboStages[currentComboIndex];
            
            if (currentTime >= stage.inputWindowStart && 
                currentTime <= stage.inputWindowEnd)
            {
                if (Input.GetButtonDown("Attack"))
                {
                    // 进入下一招
                    NextCombo();
                }
            }
            else if (currentTime > stage.duration)
            {
                // 攻击结束
                EndCombo();
            }
        }
        else
        {
            // 不在攻击中，检测攻击输入
            if (Input.GetButtonDown("Attack"))
            {
                // 检查连招是否重置
                if (Time.time - lastAttackTime > comboResetTime)
                {
                    currentComboIndex = 0;
                }
                
                StartAttack();
            }
        }
    }
    
    void StartAttack()
    {
        isAttacking = true;
        lastAttackTime = Time.time;
        
        var stage = comboStages[currentComboIndex];
        animator.Play(stage.animationName);
        
        // 造成伤害
        DealDamage(stage.damage);
    }
    
    void NextCombo()
    {
        currentComboIndex++;
        
        if (currentComboIndex >= comboStages.Length)
        {
            // 连招结束，回到第一招
            currentComboIndex = 0;
        }
        
        StartAttack();
    }
    
    void EndCombo()
    {
        isAttacking = false;
        currentComboIndex = 0;
    }
    
    void DealDamage(float damage)
    {
        // 检测范围内敌人并造成伤害
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);
        
        foreach (var enemy in hitEnemies)
        {
            enemy.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
```

#### 3. 装备系统

**数据结构**：
```csharp
// ItemData.cs
[CreateAssetMenu(fileName = "NewItem", menuName = "RPG/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite icon;
    public ItemType type;  // Weapon, Armor, Consumable等
    public int value;  // 出售价格
    
    [Header("武器属性")]
    public int attackBonus;
    public float attackSpeed;
    
    [Header("防具属性")]
    public int defenseBonus;
    public int healthBonus;
}

public enum ItemType { Weapon, Helmet, Armor, Boots, Accessory, Consumable }
```

**背包实现**：
```csharp
// Inventory.cs
public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }
    
    public List<ItemData> items = new List<ItemData>();
    public int capacity = 20;
    
    public event Action OnInventoryChanged;
    
    void Awake()
    {
        Instance = this;
    }
    
    public bool AddItem(ItemData item)
    {
        if (items.Count >= capacity)
        {
            Debug.Log("背包已满！");
            return false;
        }
        
        items.Add(item);
        OnInventoryChanged?.Invoke();
        return true;
    }
    
    public void RemoveItem(ItemData item)
    {
        items.Remove(item);
        OnInventoryChanged?.Invoke();
    }
    
    public void UseItem(int index)
    {
        if (index < 0 || index >= items.Count) return;
        
        var item = items[index];
        
        if (item.type == ItemType.Consumable)
        {
            // 使用消耗品
            PlayerStats.Instance.Heal(50);  // 假设恢复50生命
            RemoveItem(item);
        }
        else
        {
            // 装备物品
            EquipmentManager.Instance.Equip(item);
        }
    }
}
```

**装备管理器**：
```csharp
public class EquipmentManager : MonoBehaviour
{
    public static EquipmentManager Instance { get; private set; }
    
    public Dictionary<ItemType, ItemData> equippedItems = new Dictionary<ItemType, ItemData>();
    
    void Awake()
    {
        Instance = this;
    }
    
    public void Equip(ItemData item)
    {
        // 如果该位置已有装备，先卸下
        if (equippedItems.ContainsKey(item.type))
        {
            Unequip(item.type);
        }
        
        // 装备新物品
        equippedItems[item.type] = item;
        
        // 应用属性加成
        ApplyStats(item);
        
        // 更新外观
        UpdateAppearance(item);
    }
    
    public void Unequip(ItemType type)
    {
        if (equippedItems.ContainsKey(type))
        {
            var item = equippedItems[type];
            
            // 移除属性加成
            RemoveStats(item);
            
            // 放回背包
            Inventory.Instance.AddItem(item);
            
            equippedItems.Remove(type);
        }
    }
    
    void ApplyStats(ItemData item)
    {
        PlayerStats.Instance.attack += item.attackBonus;
        PlayerStats.Instance.defense += item.defenseBonus;
        PlayerStats.Instance.maxHealth += item.healthBonus;
    }
    
    void RemoveStats(ItemData item)
    {
        PlayerStats.Instance.attack -= item.attackBonus;
        PlayerStats.Instance.defense -= item.defenseBonus;
        PlayerStats.Instance.maxHealth -= item.healthBonus;
    }
}
```

---

## 六、附录：参考代码

### 常用代码片段

#### 平滑移动
```csharp
// 线性插值平滑移动
transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

// 球形插值平滑旋转
transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);

// 平滑阻尼移动（带弹性）
Vector3 velocity = Vector3.zero;
transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
```

#### 检测地面
```csharp
public bool IsGrounded()
{
    return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
}
```

#### 相机跟随
```csharp
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        
        transform.LookAt(target);
    }
}
```

#### 对象池
```csharp
public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance { get; private set; }
    
    public GameObject prefab;
    public int poolSize = 20;
    
    private Queue<GameObject> pool = new Queue<GameObject>();
    
    void Awake()
    {
        Instance = this;
        
        // 预先生成对象
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    public GameObject GetFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        
        // 池为空时创建新对象
        return Instantiate(prefab);
    }
    
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
```

---

## 附录B：常见问题100问

### 安装与配置（1-20）

**Q1：Unity Hub打不开怎么办？**
- 检查网络连接
- 关闭代理/VPN
- 以管理员身份运行
- 重新安装Unity Hub

**Q2：下载Unity编辑器速度太慢？**
- 使用Unity中国版（unity.cn）
- 夜间或凌晨下载
- 使用迅雷等多线程下载工具

**Q3：创建项目时报错"无法访问路径"？**
- 路径不要有中文
- 路径不要有特殊字符
- 检查文件夹权限

**Q4：Visual Studio无法关联Unity？**
- 安装Unity时勾选Visual Studio
- Visual Studio Installer中安装"使用Unity的游戏开发"工作负载
- Unity → Edit → Preferences → External Tools → 选择VS

**Q5：Unity许可证过期？**
- Personal版免费，需要重新登录账号
- 检查网络连接
- Unity Hub → Preferences → Licenses → Add New

### 脚本与编程（21-40）

**Q21：脚本无法挂载到GameObject？**
- 检查类名和文件名是否一致
- 检查是否继承MonoBehaviour
- 检查是否有编译错误（看Console）

**Q22：脚本中的public变量在Inspector不显示？**
- 检查是否有编译错误
- 尝试 `[SerializeField] private` 代替 `public`
- 重新打开Unity项目

**Q23：Debug.Log不显示？**
- 打开Console窗口（Window → General → Console）
- 检查是否点击了Play运行游戏
- 检查脚本是否正确挂载并启用

**Q24：变量值修改后没有保存？**
- 运行时的修改不会保存
- 停止游戏后再修改
- 使用Prefab存储默认值

**Q25：如何在脚本中找到其他GameObject？**
```csharp
// 方法1：通过名称
GameObject player = GameObject.Find("Player");

// 方法2：通过标签
GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");

// 方法3：通过组件
PlayerController player = FindObjectOfType<PlayerController>();

// 方法4：序列化引用（推荐）
public Transform target; // 拖拽赋值
```

### 物理与碰撞（41-60）

**Q41：碰撞检测不触发？**
- 两个物体都要有Collider
- 至少一个物体要有Rigidbody
- 检查Collider是否启用

**Q42：OnTriggerEnter和OnCollisionEnter的区别？**
- OnTriggerEnter：至少一个Collider勾选Is Trigger
- OnCollisionEnter：都不勾选Is Trigger，需要物理碰撞

**Q43：角色穿过地面？**
- 检查Rigidbody是否添加
- 检查Collider是否正确配置
- 检查碰撞层级设置

**Q44：碰撞后物体卡住？**
- 检查Collider大小是否合适
- 使用Rigidbody的AddForce而不是直接设置position
- 检查是否有多个Collider重叠

**Q45：2D和3D物理能混用吗？**
- 不能。2D用Rigidbody2D/Collider2D，3D用Rigidbody/Collider
- OnTrigger的参数类型不同：`OnTriggerEnter2D(Collider2D other)` vs `OnTriggerEnter(Collider other)`

### 动画与UI（61-80）

**Q61：动画不播放？**
- 检查Animator组件是否添加
- 检查Animator Controller是否赋值
- 检查动画状态机的默认状态

**Q62：动画切换不流畅？**
- 调整Transition的Duration
- 取消Has Exit Time
- 使用Blend Tree实现平滑过渡

**Q63：UI点击没有反应？**
- 检查Canvas是否有Graphic Raycaster
- 检查是否添加EventSystem
- 检查Button的OnClick事件是否绑定

**Q64：UI在不同分辨率下变形？**
- Canvas Scaler选择Scale With Screen Size
- 使用Anchor锚点正确设置位置
- Reference Resolution设为设计分辨率

**Q65：TextMeshPro中文显示方块？**
- 创建中文字体Asset
- Window → TextMeshPro → Font Asset Creator
- Character Set选择Custom Characters，粘贴中文字符

### 项目与发布（81-100）

**Q81：项目太大怎么办？**
- 删除Library文件夹（会自动重建）
- 删除未使用的资源
- 使用压缩纹理格式

**Q82：发布后游戏黑屏？**
- 检查场景是否添加到Build Settings
- 检查脚本是否有运行时错误
- 检查资源路径是否正确

**Q83：WebGL发布加载慢？**
- 压缩资源
- 减少场景大小
- 使用Addressables异步加载

**Q84：Android发布失败？**
- 安装Android Build Support
- 配置JDK和Android SDK路径
- 检查包名格式（com.company.game）

**Q85：iOS发布需要什么？**
- Mac电脑 + Xcode
- Unity安装iOS Build Support
- Apple开发者账号（$99/年）

---

## 附录C：自测题与答案

### 第1-2周自测

**题目1**：Unity Hub的作用是什么？

<details>
<summary>点击查看答案</summary>

Unity Hub用于管理多个Unity版本、项目和许可证。它让你可以：
- 安装和管理不同版本的Unity编辑器
- 创建和打开项目
- 管理账号和许可证
</details>

**题目2**：C#中，以下哪种声明方式是错误的？
```csharp
A. int number = 10;
B. float speed = 5.5;
C. string name = "Player";
D. bool isAlive = true;
```

<details>
<summary>点击查看答案</summary>

答案：B。float类型的数值必须加f后缀，正确写法是：`float speed = 5.5f;`
</details>

**题目3**：写出以下代码的输出结果：
```csharp
int a = 5;
int b = 3;
if (a > b)
{
    Debug.Log("A");
}
else
{
    Debug.Log("B");
}
```

<details>
<summary>点击查看答案</summary>

输出：A

因为 5 > 3 为真，执行if块中的代码。
</details>

**题目4**：Unity脚本中，Start()和Update()有什么区别？

<details>
<summary>点击查看答案</summary>

- Start()：脚本启动时执行一次，用于初始化
- Update()：每帧执行一次（约每秒60次），用于游戏逻辑
</details>

### 第3-4周自测

**题目5**：GameObject和Component是什么关系？

<details>
<summary>点击查看答案</summary>

- GameObject是容器，代表场景中的一个物体
- Component是功能模块，挂载到GameObject上
- 一个GameObject可以挂载多个Component
- 所有GameObject都有Transform组件（无法删除）
</details>

**题目6**：如何让两个物体发生碰撞？

<details>
<summary>点击查看答案</summary>

1. 两个物体都要有Collider组件
2. 至少一个物体要有Rigidbody组件
3. 如果是Trigger碰撞，至少一个Collider勾选Is Trigger
</details>

**题目7**：Rigidbody的Is Kinematic选项是什么意思？

<details>
<summary>点击查看答案</summary>

- Is Kinematic = true：物体不受物理引擎控制（重力、碰撞力），只能通过代码移动
- Is Kinematic = false：物体受物理引擎控制，会被撞飞、下落等
</details>

### 第5-6周自测

**题目8**：2D和3D物理系统的区别？

<details>
<summary>点击查看答案</summary>

| 2D物理 | 3D物理 |
|--------|--------|
| Rigidbody2D | Rigidbody |
| Collider2D | Collider |
| Vector2 | Vector3 |
| OnTriggerEnter2D | OnTriggerEnter |

注意：2D和3D物理不能混用！
</details>

**题目9**：如何实现角色翻转（面向左/右）？

<details>
<summary>点击查看答案</summary>

```csharp
void Flip()
{
    facingRight = !facingRight;
    Vector3 scale = transform.localScale;
    scale.x *= -1;  // x轴缩放取反
    transform.localScale = scale;
}
```
</details>

### 第7-9周自测

**题目10**：Animator Controller的参数类型有哪些？分别用于什么场景？

<details>
<summary>点击查看答案</summary>

| 类型 | 用途 | 示例 |
|------|------|------|
| Float | 浮点数 | 移动速度、血量百分比 |
| Int | 整数 | 武器类型编号、连击数 |
| Bool | 布尔值 | 是否在地面上、是否攻击中 |
| Trigger | 触发器 | 攻击、跳跃（使用一次后自动重置） |
</details>

---

## 附录D：快捷键大全

### Scene视图导航

| 快捷键 | 功能 |
|--------|------|
| 鼠标右键拖动 | 旋转视角 |
| 鼠标中键拖动 | 平移视角 |
| 鼠标滚轮 | 缩放 |
| 双击Hierarchy对象 | 聚焦该对象 |
| F | 聚焦选中对象 |
| Shift+F | 锁定跟随选中对象 |

### 变换工具

| 快捷键 | 功能 |
|--------|------|
| Q | 手型工具（平移视图） |
| W | 移动工具 |
| E | 旋转工具 |
| R | 缩放工具 |
| T | 矩形工具（2D常用） |

### 播放与调试

| 快捷键 | 功能 |
|--------|------|
| Ctrl+P | 播放/停止 |
| Ctrl+Shift+P | 暂停 |
| Ctrl+Alt+P | 逐帧执行 |

### 文件操作

| 快捷键 | 功能 |
|--------|------|
| Ctrl+S | 保存场景 |
| Ctrl+Shift+S | 场景另存为 |
| Ctrl+N | 新建场景 |
| Ctrl+O | 打开场景 |

### 编辑操作

| 快捷键 | 功能 |
|--------|------|
| Ctrl+Z | 撤销 |
| Ctrl+Y | 重做 |
| Ctrl+D | 复制选中对象 |
| Ctrl+Shift+D | 复制组件 |
| Delete | 删除选中对象 |
| Ctrl+Shift+F | 将对象对齐到视图 |

### GameObject创建

| 快捷键 | 功能 |
|--------|------|
| Ctrl+Shift+N | 创建空对象 |
| Ctrl+Alt+F | 创建空子对象 |

### 组件操作

| 快捷键 | 功能 |
|--------|------|
| Ctrl+Shift+A | 添加组件 |
| Alt+↑/↓ | 移动组件位置 |

---

**文档版本**：v2.0  
**最后更新**：2026年4月8日  
**下一步行动**：打开 [`README.md`](README.md) 开始学习！
