# C# 基础语法速成

> 本文档是 `完整自学指南.md` 第3章的详细补充  
> 适合完全没有编程基础的读者

---

## 目录

1. [什么是编程](#1-什么是编程)
2. [变量与数据类型](#2-变量与数据类型)
3. [运算符](#3-运算符)
4. [条件语句](#4-条件语句)
5. [循环语句](#5-循环语句)
6. [数组与集合](#6-数组与集合)
7. [方法](#7-方法)
8. [类与对象](#8-类与对象)
9. [继承与多态](#9-继承与多态)
10. [常用Unity API](#10-常用unity-api)

---

## 1. 什么是编程

### 1.1 编程的本质

编程就是**给计算机下达指令**，让它按照你的想法工作。

想象你在教一个机器人做菜：
```
1. 打开冰箱
2. 取出鸡蛋
3. 打碎鸡蛋
4. 加热平底锅
5. 倒入蛋液
6. 等待30秒
7. 翻面
8. 盛盘
```

编程就是把这些步骤用**编程语言**写下来，让计算机执行。

### 1.2 C# 在 Unity 中的作用

Unity 是一个游戏引擎，提供了：
- 图形渲染（显示画面）
- 物理模拟（碰撞、重力）
- 音频播放
- 输入处理（键盘、鼠标、触摸）

**C# 的作用**是控制这些功能：
- 什么时候播放声音
- 角色按什么键移动
- 碰到敌人后发生什么
- 游戏何时结束

### 1.3 第一个程序

在 Unity 中创建脚本，你会看到：

```csharp
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is游戏开始时执行一次
    void Start()
    {
        Debug.Log("Hello, Unity!");
    }

    // Update 是每帧执行一次
    void Update()
    {
        
    }
}
```

**逐行解释**：

| 行 | 代码 | 含义 |
|----|------|------|
| 1 | `using UnityEngine;` | 引入Unity的功能库 |
| 2 | `using System.Collections;` | 引入系统的集合库 |
| 4 | `public class NewBehaviourScript : MonoBehaviour` | 定义一个类，继承自MonoBehaviour |
| 6 | `void Start()` | Start方法，游戏开始时执行一次 |
| 8 | `Debug.Log("Hello, Unity!");` | 在控制台输出文字 |
| 11 | `void Update()` | Update方法，每帧执行一次 |

---

## 2. 变量与数据类型

### 2.1 什么是变量

变量就是**存储数据的容器**，每个容器有一个名字（变量名）和类型（存储什么类型的数据）。

生活中的例子：
- 杯子（容器）→ 变量
- 杯子里的水（内容）→ 变量的值
- "我的水杯"（名字）→ 变量名
- 能装液体（类型）→ 数据类型

### 2.2 常用数据类型

| 类型 | 关键字 | 存储内容 | 示例 |
|------|--------|----------|------|
| 整数 | `int` | 整数 | `int age = 25;` |
| 浮点数 | `float` | 小数 | `float speed = 5.5f;` |
| 字符串 | `string` | 文本 | `string name = "Player";` |
| 布尔 | `bool` | 真/假 | `bool isAlive = true;` |
| 字符 | `char` | 单个字符 | `char grade = 'A';` |

**注意**：
- `float` 类型的数值必须加 `f` 后缀：`5.5f`（不是 `5.5`）
- `string` 用双引号：`"Hello"`
- `char` 用单引号：`'A'`

### 2.3 变量声明与赋值

```csharp
// 声明并赋值
int score = 0;

// 先声明，后赋值
int level;
level = 1;

// 同时声明多个变量
int x = 1, y = 2, z = 3;
```

### 2.4 变量命名规则

**允许**：
- 字母、数字、下划线
- `playerName`、`score1`、`_count`

**不允许**：
- 数字开头：`1player`
- 关键字：`int`、`class`、`void`
- 特殊字符：`player-name`、`score!`

**命名规范**：
- 变量名用小驼峰：`playerHealth`、`moveSpeed`
- 类名用大驼峰：`PlayerController`、`GameManager`
- 常量用全大写：`MAX_HEALTH`、`DEFAULT_SPEED`

### 2.5 Unity 特有类型

| 类型 | 说明 | 示例 |
|------|------|------|
| `Vector2` | 2D向量 | `Vector2 pos = new Vector2(1, 2);` |
| `Vector3` | 3D向量 | `Vector3 pos = new Vector3(1, 2, 3);` |
| `Color` | 颜色 | `Color red = Color.red;` |
| `GameObject` | 游戏对象 | `GameObject player;` |
| `Transform` | 变换组件 | `Transform t = transform;` |

---

## 3. 运算符

### 3.1 算术运算符

| 运算符 | 说明 | 示例 |
|--------|------|------|
| `+` | 加法 | `5 + 3 = 8` |
| `-` | 减法 | `5 - 3 = 2` |
| `*` | 乘法 | `5 * 3 = 15` |
| `/` | 除法 | `6 / 3 = 2` |
| `%` | 取余 | `7 % 3 = 1` |

**字符串拼接**：
```csharp
string name = "玩家";
int score = 100;
string message = name + "得分：" + score;  // "玩家得分：100"
```

### 3.2 比较运算符

| 运算符 | 说明 | 示例 |
|--------|------|------|
| `==` | 等于 | `5 == 5` → true |
| `!=` | 不等于 | `5 != 3` → true |
| `>` | 大于 | `5 > 3` → true |
| `<` | 小于 | `3 < 5` → true |
| `>=` | 大于等于 | `5 >= 5` → true |
| `<=` | 小于等于 | `3 <= 5` → true |

### 3.3 逻辑运算符

| 运算符 | 说明 | 示例 |
|--------|------|------|
| `&&` | 且（两个都为真） | `true && true` → true |
| `\|\|` | 或（至少一个为真） | `true \|\| false` → true |
| `!` | 非（取反） | `!true` → false |

**示例**：
```csharp
int health = 30;
int maxHealth = 100;

// 检查是否存活且血量低于50%
bool isLowHealth = health > 0 && health < maxHealth * 0.5f;  // true

// 检查是否死亡或满血
bool isDeadOrFull = health <= 0 || health >= maxHealth;  // false
```

### 3.4 赋值运算符

| 运算符 | 等价写法 | 示例 |
|--------|----------|------|
| `+=` | `a = a + b` | `score += 10` |
| `-=` | `a = a - b` | `health -= 5` |
| `*=` | `a = a * b` | `speed *= 2` |
| `/=` | `a = a / b` | `time /= 2` |
| `++` | `a = a + 1` | `level++` |
| `--` | `a = a - 1` | `count--` |

---

## 4. 条件语句

### 4.1 if 语句

```csharp
if (条件)
{
    // 条件为真时执行
}
```

**示例**：
```csharp
int score = 85;

if (score >= 60)
{
    Debug.Log("及格了！");
}
```

### 4.2 if-else 语句

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

**示例**：
```csharp
int score = 55;

if (score >= 60)
{
    Debug.Log("及格了！");
}
else
{
    Debug.Log("不及格！");
}
```

### 4.3 if-else if-else

```csharp
int score = 85;

if (score >= 90)
{
    Debug.Log("优秀！");
}
else if (score >= 80)
{
    Debug.Log("良好！");
}
else if (score >= 60)
{
    Debug.Log("及格！");
}
else
{
    Debug.Log("不及格！");
}
```

### 4.4 三目运算符

```csharp
// 格式：条件 ? 真值 : 假值
string result = score >= 60 ? "及格" : "不及格";
```

### 4.5 switch 语句

适合多分支判断：

```csharp
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "星期一";
        break;
    case 2:
        dayName = "星期二";
        break;
    case 3:
        dayName = "星期三";
        break;
    default:
        dayName = "其他";
        break;
}

Debug.Log(dayName);  // "星期三"
```

---

## 5. 循环语句

### 5.1 for 循环

适合已知循环次数：

```csharp
// 格式：for (初始化; 条件; 更新)
for (int i = 0; i < 5; i++)
{
    Debug.Log("第 " + i + " 次");
}
// 输出：第 0 次、第 1 次、第 2 次、第 3 次、第 4 次
```

### 5.2 while 循环

适合未知循环次数：

```csharp
int count = 0;

while (count < 5)
{
    Debug.Log("count = " + count);
    count++;
}
```

### 5.3 do-while 循环

至少执行一次：

```csharp
int count = 0;

do
{
    Debug.Log("count = " + count);
    count++;
} while (count < 5);
```

### 5.4 foreach 循环

遍历集合：

```csharp
string[] names = { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Debug.Log("姓名：" + name);
}
```

### 5.5 break 和 continue

```csharp
// break：跳出整个循环
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break;  // 循环在 i=5 时结束
    Debug.Log(i);
}
// 输出：0, 1, 2, 3, 4

// continue：跳过当前迭代
for (int i = 0; i < 5; i++)
{
    if (i == 2)
        continue;  // 跳过 i=2
    Debug.Log(i);
}
// 输出：0, 1, 3, 4
```

---

## 6. 数组与集合

### 6.1 数组

固定长度，存储相同类型：

```csharp
// 声明并初始化
int[] scores = { 100, 90, 80, 70, 60 };

// 先声明后初始化
int[] levels = new int[5];  // 长度为5，默认值0
levels[0] = 1;

// 访问元素
Debug.Log(scores[0]);  // 100（索引从0开始）

// 数组长度
Debug.Log(scores.Length);  // 5

// 遍历数组
for (int i = 0; i < scores.Length; i++)
{
    Debug.Log("分数：" + scores[i]);
}
```

### 6.2 List（动态数组）

长度可变，更灵活：

```csharp
using System.Collections.Generic;

// 创建List
List<int> scores = new List<int>();

// 添加元素
scores.Add(100);
scores.Add(90);
scores.Add(80);

// 访问元素
Debug.Log(scores[0]);  // 100

// 元素个数
Debug.Log(scores.Count);  // 3

// 删除元素
scores.Remove(90);  // 删除值为90的元素
scores.RemoveAt(0); // 删除索引0的元素

// 遍历
foreach (int score in scores)
{
    Debug.Log(score);
}
```

### 6.3 Dictionary（字典）

键值对存储：

```csharp
using System.Collections.Generic;

// 创建字典
Dictionary<string, int> playerScores = new Dictionary<string, int>();

// 添加元素
playerScores.Add("Alice", 100);
playerScores.Add("Bob", 90);

// 访问元素
Debug.Log(playerScores["Alice"]);  // 100

// 检查键是否存在
if (playerScores.ContainsKey("Bob"))
{
    Debug.Log("Bob的分数：" + playerScores["Bob"]);
}

// 遍历
foreach (var pair in playerScores)
{
    Debug.Log(pair.Key + ": " + pair.Value);
}
```

---

## 7. 方法

### 7.1 方法定义

```csharp
// 格式：返回类型 方法名(参数列表)
//{
//    方法体
//}

// 无返回值，无参数
void SayHello()
{
    Debug.Log("Hello!");
}

// 无返回值，有参数
void Greet(string name)
{
    Debug.Log("Hello, " + name + "!");
}

// 有返回值，有参数
int Add(int a, int b)
{
    return a + b;
}
```

### 7.2 方法调用

```csharp
void Start()
{
    SayHello();              // Hello!
    Greet("Alice");          // Hello, Alice!
    
    int sum = Add(3, 5);     // sum = 8
    Debug.Log(sum);
}
```

### 7.3 参数修饰符

```csharp
// ref：引用传递，修改会影响原变量
void Double(ref int num)
{
    num *= 2;
}

int x = 5;
Double(ref x);  // x 变成 10

// out：输出参数，必须赋值后返回
void GetPosition(out int x, out int y)
{
    x = 10;
    y = 20;
}

int posX, posY;
GetPosition(out posX, out posY);  // posX=10, posY=20

// params：可变参数
int Sum(params int[] numbers)
{
    int total = 0;
    foreach (int n in numbers)
        total += n;
    return total;
}

int result = Sum(1, 2, 3, 4, 5);  // 15
```

### 7.4 方法重载

同名方法，参数不同：

```csharp
int Add(int a, int b)
{
    return a + b;
}

float Add(float a, float b)
{
    return a + b;
}

string Add(string a, string b)
{
    return a + b;
}
```

---

## 8. 类与对象

### 8.1 类的定义

类是对象的模板：

```csharp
public class Player
{
    // 字段（成员变量）
    public string name;
    public int health;
    public int maxHealth = 100;
    
    // 属性
    public bool IsAlive
    {
        get { return health > 0; }
    }
    
    // 构造函数
    public Player(string name)
    {
        this.name = name;
        this.health = maxHealth;
    }
    
    // 方法
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
    }
    
    public void Heal(int amount)
    {
        health += amount;
        if (health > maxHealth)
            health = maxHealth;
    }
}
```

### 8.2 对象的创建与使用

```csharp
// 创建对象
Player player = new Player("勇者");

// 访问字段
Debug.Log(player.name);     // "勇者"
Debug.Log(player.health);   // 100

// 调用方法
player.TakeDamage(30);
Debug.Log(player.health);   // 70

// 使用属性
Debug.Log(player.IsAlive);  // true
```

### 8.3 访问修饰符

| 修饰符 | 说明 |
|--------|------|
| `public` | 公开，任何地方可访问 |
| `private` | 私有，只有类内部可访问 |
| `protected` | 保护，类内部和子类可访问 |
| `internal` | 内部，同一程序集可访问 |

### 8.4 静态成员

属于类本身，不属于对象：

```csharp
public class GameSettings
{
    public static int maxPlayers = 4;
    public static float volume = 0.8f;
    
    public static void Reset()
    {
        volume = 0.8f;
    }
}

// 使用静态成员（不需要创建对象）
Debug.Log(GameSettings.maxPlayers);  // 4
GameSettings.volume = 0.5f;
GameSettings.Reset();
```

---

## 9. 继承与多态

### 9.1 继承

子类继承父类的成员：

```csharp
// 父类
public class Enemy
{
    public string name;
    public int health;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(name + "受到" + damage + "点伤害");
    }
}

// 子类
public class Boss : Enemy
{
    public int phase;  // 新增字段
    
    public void ChangePhase()
    {
        phase++;
        Debug.Log(name + "进入第" + phase + "阶段");
    }
}

// 使用
Boss boss = new Boss();
boss.name = "魔王";
boss.health = 1000;
boss.TakeDamage(100);     // 继承的方法
boss.ChangePhase();       // 子类自己的方法
```

### 9.2 重写（override）

子类可以重写父类的虚方法：

```csharp
public class Enemy
{
    public virtual void Attack()
    {
        Debug.Log("敌人攻击");
    }
}

public class Boss : Enemy
{
    public override void Attack()
    {
        Debug.Log("Boss释放大招");
    }
}

Enemy enemy = new Boss();
enemy.Attack();  // "Boss释放大招"（多态）
```

### 9.3 抽象类

不能实例化，用于定义规范：

```csharp
public abstract class Character
{
    public string name;
    public int health;
    
    // 抽象方法：子类必须实现
    public abstract void Die();
}

public class Player : Character
{
    public override void Die()
    {
        Debug.Log(name + "阵亡，游戏结束");
    }
}
```

### 9.4 接口

定义行为规范：

```csharp
public interface IDamageable
{
    void TakeDamage(int damage);
}

public class Player : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damage)
    {
        // 实现接口方法
    }
}
```

---

## 10. 常用Unity API

### 10.1 GameObject 操作

```csharp
// 查找GameObject
GameObject player = GameObject.Find("Player");
GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

// 创建GameObject
GameObject obj = new GameObject("NewObject");
GameObject instance = Instantiate(prefab);

// 销毁GameObject
Destroy(gameObject);
Destroy(gameObject, 2f);  // 2秒后销毁

// 激活/禁用
gameObject.SetActive(true);
gameObject.SetActive(false);
```

### 10.2 Transform 操作

```csharp
// 位置
transform.position = new Vector3(0, 1, 0);
Vector3 pos = transform.position;

// 旋转
transform.rotation = Quaternion.Euler(0, 90, 0);
transform.Rotate(0, 10, 0);  // 相对旋转

// 缩放
transform.localScale = new Vector3(2, 2, 2);

// 移动
transform.Translate(Vector3.forward * speed * Time.deltaTime);

// 查找子物体
Transform child = transform.Find("ChildName");
Transform child = transform.GetChild(0);  // 索引0的子物体
```

### 10.3 Rigidbody 操作

```csharp
Rigidbody rb = GetComponent<Rigidbody>();

// 添加力
rb.AddForce(Vector3.up * 500);
rb.AddForce(Vector3.forward * 100, ForceMode.Impulse);

// 设置速度
rb.velocity = new Vector3(0, 10, 0);

// 位置移动（物理友好）
rb.MovePosition(transform.position + Vector3.forward);
```

### 10.4 输入检测

```csharp
// 按键检测
if (Input.GetKey(KeyCode.Space))        // 按住
if (Input.GetKeyDown(KeyCode.Space))    // 按下瞬间
if (Input.GetKeyUp(KeyCode.Space))      // 松开瞬间

// 轴输入
float horizontal = Input.GetAxis("Horizontal");   // -1 到 1
float vertical = Input.GetAxis("Vertical");

// 鼠标
if (Input.GetMouseButton(0))           // 左键按住
if (Input.GetMouseButtonDown(0))       // 左键按下
Vector3 mousePos = Input.mousePosition;
```

### 10.5 时间

```csharp
float time = Time.time;           // 游戏开始后经过的时间
float deltaTime = Time.deltaTime; // 上一帧到这一帧的时间
float fps = 1 / Time.deltaTime;   // 帧率

// 暂停游戏
Time.timeScale = 0;
// 恢复游戏
Time.timeScale = 1;
```

### 10.6 场景管理

```csharp
using UnityEngine.SceneManagement;

// 加载场景
SceneManager.LoadScene("Level2");
SceneManager.LoadScene(1);  // 通过索引

// 重新加载当前场景
SceneManager.LoadScene(SceneManager.GetActiveScene().name);

// 获取场景名称
string sceneName = SceneManager.GetActiveScene().name;
```

---

## 快速参考卡片

### 变量声明
```csharp
int number = 10;
float speed = 5.5f;
string name = "Player";
bool isAlive = true;
Vector3 pos = new Vector3(0, 1, 0);
```

### 条件语句
```csharp
if (condition) { }
else if (condition) { }
else { }
```

### 循环
```csharp
for (int i = 0; i < 10; i++) { }
while (condition) { }
foreach (var item in collection) { }
```

### 方法
```csharp
void MethodName() { }
int MethodName(int param) { return param; }
```

### 类
```csharp
public class ClassName
{
    public int field;
    public void Method() { }
}
```

---

**下一步**：回到 [`完整自学指南.md`](../完整自学指南.md) 继续学习 Unity 核心组件！
