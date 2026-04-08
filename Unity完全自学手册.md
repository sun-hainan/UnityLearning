# Unity + C# 完全自学指南（终极版）

> 📅 版本：v2.0 终极完全版  
> 📁 位置：`F:\UnityLearning\`  
> 🎯 目标：只看本文档，从完全零基础到能独立开发游戏  
> ⚠️ 承诺：不需要任何外部资料（视频、网站、搜索引擎）

---

## 目录

**第一部分：环境准备**
- [第0章：计算机基础检查](#第0章计算机基础检查)
- [第1章：Unity安装详解](#第1章unity安装详解)

**第二部分：Unity入门（第1-2个月）**
- [第2章：Unity界面全解析](#第2章unity界面全解析)
- [第3章：C#编程基础](#第3章c编程基础)
- [第4章：游戏对象与组件](#第4章游戏对象与组件)
- [第5章：物理系统](#第5章物理系统)
- [第6章：2D游戏基础](#第6章2d游戏基础)
- [第7章：动画系统](#第7章动画系统)
- [第8章：UI系统](#第8章ui系统)
- [第9章：阶段一综合项目](#第9章阶段一综合项目)

**第三部分：项目实践（第3-4个月）**
- [第10章：如何阅读项目代码](#第10章如何阅读项目代码)
- [第11章：2D射击游戏复刻](#第11章2d射击游戏复刻)

**第四部分：进阶开发（第5-6个月）**
- [第12章：设计模式](#第12章设计模式)
- [第13章：事件系统与架构](#第13章事件系统与架构)
- [第14章：存档系统](#第14章存档系统)
- [第15章：AI与行为树](#第15章ai与行为树)

**第五部分：高级开发（第7-8个月）**
- [第16章：有限状态机](#第16章有限状态机)
- [第17章：战斗系统](#第17章战斗系统)
- [第18章：装备与背包系统](#第18章装备与背包系统)
- [第19章：优化与发布](#第19章优化与发布)

**附录**
- [附录A：完整代码库](#附录a完整代码库)
- [附录B：常见问题100问](#附录b常见问题100问)
- [附录C：自测题与答案](#附录c自测题与答案)
- [附录D：快捷键大全](#附录d快捷键大全)

---

# 第一部分：环境准备

## 第0章：计算机基础检查

### 0.1 你的电脑能跑Unity吗？

**最低配置要求**：
- 操作系统：Windows 10 64位
- 内存：8GB（推荐16GB）
- 硬盘：至少10GB空闲空间
- 显卡：支持DirectX 11的显卡

**检查方法**：
1. 按 `Win + R`，输入 `dxdiag`，回车
2. 看"系统"标签页的内存
3. 看"显示"标签页的显卡型号

**如果配置不够怎么办？**
- 内存不够：先学C#编程（不需要Unity）
- 硬盘不够：清理空间或加硬盘
- 显卡不够：可以学，但运行3D项目会卡

### 0.2 你需要知道的基础概念

**文件路径**：
- `F:\UnityLearning\` 表示F盘下的UnityLearning文件夹
- `\` 是Windows的路径分隔符
- 不要用中文路径！用 `F:\UnityProjects\` 而不是 `F:\游戏项目\`

**文件扩展名**：
- `.cs` = C#代码文件
- `.unity` = Unity场景文件
- `.prefab` = Unity预制体文件
- `.png/.jpg` = 图片
- `.wav/.mp3` = 音频

**如何显示文件扩展名**：
1. 打开任意文件夹
2. 点击"查看"标签
3. 勾选"文件扩展名"

---

## 第1章：Unity安装详解（中国境内版）

> ⚠️ **中国境内特别提示**：由于网络环境差异，推荐以下国内可用的下载方式

### 1.0 Unity中国版 vs 国际版

**有什么区别？**
| 对比项 | Unity国际版 | Unity中国版 |
|--------|-------------|-------------|
| 官网 | unity.com | unity.cn |
| 服务器 | 海外 | 国内（下载更快） |
| 功能 | 完整功能 | 完整功能 + 中国定制服务 |
| 账号 | 国际账号 | 需要绑定手机号 |
| 本教程适配 | ✅ 完全适配 | ✅ 完全适配 |

**推荐选择**：两个版本功能完全一致，**建议下载中国版**（下载速度快）

---

### 1.1 下载Unity Hub（中国境内推荐方式）

#### 方式一：Unity中国官网（推荐⭐）
**步骤1：访问中国官网**
- 浏览器地址栏输入：`unity.cn`
- 或搜索"Unity中国"

**步骤2：下载Unity Hub**
- 首页点击"下载Unity"
- 选择"Unity Hub"
- 点击"下载Windows版"

**步骤3：运行安装程序**
- 下载完成后，打开下载文件夹
- 双击 `UnityHubSetup.exe`
- 如果弹出"是否允许此应用更改设备"，点"是"
- 安装界面：
  - 语言选"简体中文"
  - 安装路径建议保持默认（`C:\Program Files\Unity Hub\`）
  - 点击"安装"
- 等待安装完成（约1-2分钟）

**步骤4：启动Unity Hub**
- 安装完成后，勾选"运行Unity Hub"
- 点击"完成"
- Unity Hub启动

#### 方式二：国际版官网（备用）
- 地址：`unity.com/download`
- ⚠️ 注意：国内访问可能需要较长时间加载

#### 方式三：网盘镜像（网络不佳时使用）
如果官网下载慢，可以使用以下国内镜像：
- 腾讯软件中心：搜索"Unity Hub"
- 华军软件园：搜索"Unity Hub"
- 注意：从第三方下载后，仍需登录Unity账号使用

---

### 1.1a 网络问题解决方案

**问题1：官网打不开或加载慢**
- 尝试切换DNS：使用`223.5.5.5`（阿里DNS）或`114.114.114.114`
- 或者使用手机热点下载

**问题2：下载速度极慢**
- 使用下载工具：迅雷、IDM等多线程下载
- 或者在晚上/凌晨下载（网络相对通畅）

**问题3：安装时提示网络错误**
- 关闭代理/VPN软件
- 检查防火墙是否拦截Unity Hub

### 1.2 注册Unity账号

**为什么需要账号？**
- 免费使用Unity Personal版
- 下载和管理Unity版本
- 访问Asset Store

**注册步骤**：
1. Unity Hub点击"创建账号"
2. 填写：
   - 邮箱（用真实邮箱，需要验证）
   - 密码（至少8位，含大小写+数字）
   - 用户名
   - 国家/地区：China
3. 勾选"我同意"
4. 点击"创建账号"
5. 去邮箱查收验证邮件，点击链接验证
6. 回到Unity Hub登录

### 1.3 安装Unity编辑器（中国境内适配）

**关于Unity版本选择（中国境内）**：
- **推荐版本**：Unity 2022.3 LTS（长期支持版）
- **国内可用性**：✅ 完全可用，中国版和国际版都提供此版本
- **稳定性**：LTS版本最稳定，适合学习

**步骤1：打开偏好设置**
- Unity Hub点击右上角齿轮图标
- 选择"偏好设置"
- 点击"外部工具"
- 确保勾选了"Visual Studio"（会自动安装）

**步骤2：安装Unity**
- 点击左侧"安装"
- 点击右上角"安装编辑器"
- **选择版本**：Unity 2022.3 LTS（或更高版本的中国版）
- **重要**：点击"下一步"后，勾选以下模块：
  - [x] Microsoft Visual Studio Community 2022（代码编辑器）
  - [x] Windows Build Support (Mono)（Windows打包支持）
  - [x] Documentation（离线文档）
  - [ ] Android Build Support（可选，如需发布到手机）
  - [ ] iOS Build Support（可选，Mac用户）
- 点击"安装"

**步骤3：加速下载（中国境内）**
如果下载速度慢，可以尝试：
1. 使用下载工具的镜像加速功能
2. 在Unity Hub设置中添加国内镜像（如有）
3. 夜间下载（网络相对通畅）

**预计时间**：30-120分钟（取决于网络速度）

**国内常见问题**：

Q：提示"无法连接到Unity服务"
- 检查网络连接
- 尝试关闭代理软件
- 重启Unity Hub

Q：下载到一半失败
- 检查磁盘空间（至少20GB）
- 尝试重新点击安装，会继续下载
- 或删除未完成的安装，重新开始

### 1.4 创建第一个项目（测试安装）

**步骤1：创建新项目**
- Unity Hub点击左侧"项目"
- 点击"新项目"
- 选择"3D"模板
- 项目名称：`TestProject`
- 位置：`F:\UnityLearning\Projects\`
- 点击"创建项目"

**步骤2：验证安装成功**
- 等待项目加载（首次较慢，约2-3分钟）
- 如果看到3D场景中有Cube和Directional Light，说明成功！
- 点击顶部中间的▶️按钮（Play）
- 如果Game窗口变黑但能运行，说明一切正常！

**常见问题**：

Q1：提示"显卡驱动不支持"
- 更新显卡驱动（使用驱动人生、驱动精灵等工具）
- 或安装DirectX 11运行时

Q2：打开项目后闪退
- 检查路径是否有中文或特殊字符
- 路径格式应为：`F:\UnityProjects\MyGame` ✓
- 不要这样：`F:\游戏项目\我的游戏` ✗

Q3：界面是英文的
- Edit → Preferences → Languages → 简体中文
- 如果没有中文选项，需要下载中文语言包

Q4（中国境内特有问题）：Unity Hub登录不上
- 检查网络连接
- 尝试使用手机热点
- 或者使用Unity中国版（unity.cn）

Q5（中国境内特有问题）：Asset Store打不开
- 使用国内镜像资源站
- 或搜索"Unity Asset Store 国内下载"

---

# 第二部分：Unity入门（第1-2个月）

## 第2章：Unity界面全解析

### 2.1 首次打开Unity

当你打开Unity项目后，会看到一个复杂的界面。别慌，我们逐个击破。

**界面布局**（默认2 by 3布局）：
```
┌─────────────────┬─────────────┐
│   Scene视图      │  Game视图   │
│   (场景编辑)     │  (游戏预览) │
├─────────────────┼─────────────┤
│   Project视图    │ Inspector   │
│   (项目文件)     │ (属性检查器)│
├─────────────────┴─────────────┤
│      Console (控制台)         │
└───────────────────────────────┘
```

### 2.2 Scene视图（场景视图）

**这是哪里？**
- 你的工作台，就像3D建模软件的编辑区
- 在这里摆放物体、调整位置、搭建场景

**基本操作**：

| 操作 | 鼠标/键盘 | 效果 |
|------|----------|------|
| 旋转视角 | 按住右键 + 移动鼠标 | 环顾四周 |
| 平移视角 | 按住中键 + 移动鼠标 | 左右上下移动视图 |
| 缩放 | 滚轮 | 放大/缩小 |
| 聚焦物体 | 选中物体 + 按F | 视角对准该物体 |

**工具栏（Scene视图上方）**：

| 图标 | 快捷键 | 功能 |
|------|--------|------|
| 手型 | Q | 平移视图 |
| 四向箭头 | W | 移动物体 |
| 环形箭头 | E | 旋转物体 |
| 方块箭头 | R | 缩放物体 |
| 矩形 | T | 2D矩形工具 |

**练习**：
1. 选中场景中的Cube（点击它）
2. 按W，出现红绿蓝三个箭头
3. 拖动红色箭头，Cube沿X轴移动
4. 按E，出现三个旋转环
5. 拖动绿色环，Cube绕Y轴旋转

### 2.3 Game视图（游戏视图）

**这是哪里？**
- 玩家看到的画面
- 点击Play按钮后，从这里看游戏运行效果

**与Scene的区别**：
- Scene：开发者视角，可以选中物体、看到所有东西
- Game：玩家视角，只显示Camera看到的内容

**控制栏**：
- Free Aspect：选择屏幕比例（16:9, 4:3等）
- Scale：缩放显示（不影响实际游戏）
- Maximize on Play：运行时最大化（建议勾选）

### 2.4 Hierarchy视图（层级视图）

**这是哪里？**
- 当前场景中所有游戏对象的列表
- 类似Photoshop的图层列表

**核心概念**：
- **游戏对象(GameObject)**：场景中的任何东西（角色、灯光、相机、道具）
- **父子关系**：拖动一个对象到另一个对象上，就建立了父子关系

**操作**：
- 双击对象名：在Scene视图聚焦它
- 点击眼睛图标：隐藏/显示
- 右键 → Create Empty：创建空对象（常用于组织管理）

**练习**：
1. 在Hierarchy右键 → Create Empty
2. 改名为"Environment"
3. 把Directional Light拖到Environment下
4. 观察：Light变成了Environment的子对象

### 2.5 Inspector视图（检查器视图）

**这是哪里？**
- 显示选中对象的属性
- 在这里修改参数、添加组件

**组成**：
1. **顶部**：对象名、Tag、Layer
2. **Transform组件**：位置、旋转、缩放
3. **其他组件**：根据对象类型不同

**Transform详解**：
```
Position（位置）
  X: 0    ← 左右位置
  Y: 0    ← 上下位置
  Z: 0    ← 前后位置

Rotation（旋转）
  X: 0    ← 绕X轴旋转（俯仰）
  Y: 0    ← 绕Y轴旋转（左右转）
  Z: 0    ← 绕Z轴旋转（侧倾）

Scale（缩放）
  X: 1    ← 宽度
  Y: 1    ← 高度
  Z: 1    ← 深度
```

**练习**：
1. 选中Cube
2. 在Inspector找到Position
3. 把Y改成5，回车
4. 观察：Cube向上移动了5个单位
5. 把Scale的X改成2
6. 观察：Cube变宽了

### 2.6 Project视图（项目视图）

**这是哪里？**
- 项目的所有资源文件
- 类似Windows资源管理器

**重要文件夹**：
```
Assets/           ← 所有资源放这里
  Scripts/        ← C#代码
  Sprites/        ← 2D图片
  Materials/      ← 材质
  Prefabs/        ← 预制体
  Scenes/         ← 场景文件
  Audio/          ← 音频
```

**操作**：
- 右键 → Create → Folder：创建文件夹
- 右键 → Create → C# Script：创建脚本
- 拖拽：把文件拖到Hierarchy创建对象

### 2.7 Console视图（控制台视图）

**这是哪里？**
- 显示错误、警告、日志信息
- 编程时最重要的调试工具

**信息类型**：
- 🔴 红色 = 错误（Error）：必须修复
- 🟡 黄色 = 警告（Warning）：建议修复
- ⚪ 白色 = 普通日志（Log）：调试信息

**常用代码**：
```csharp
Debug.Log("普通信息");        // 白色
Debug.LogWarning("警告信息"); // 黄色
Debug.LogError("错误信息");   // 红色
```

---

## 第3章：C#编程基础

### 3.1 什么是编程？

**通俗理解**：
- 编程 = 写指令让电脑做事
- C# = 一种编程语言（类似英语、汉语）
- Unity用C#控制游戏逻辑

**第一个程序**：
```csharp
// 这是一行注释，电脑会忽略
/* 这也是注释，
   可以写多行 */

Debug.Log("Hello, World!");  // 在控制台显示文字
```

### 3.2 创建第一个脚本

**步骤1：创建文件**
1. Project窗口右键 → Create → C# Script
2. 命名为"HelloWorld"
3. 双击打开（会自动打开Visual Studio）

**步骤2：认识代码结构**
```csharp
// 第1行：引入Unity的功能
using UnityEngine;

// 第4行：定义一个类（类名必须和文件名一致）
public class HelloWorld : MonoBehaviour
{
    // Start()：游戏开始时执行一次
    void Start()
    {
        Debug.Log("游戏开始了！");
    }

    // Update()：每帧执行（每秒约60次）
    void Update()
    {
        // 暂时空着
    }
}
```

**步骤3：运行脚本**
1. 保存代码（Ctrl + S）
2. 回到Unity
3. 把脚本拖到Hierarchy的任意对象（如Main Camera）
4. 点击Play
5. 看Console，显示"游戏开始了！"

### 3.3 变量（存储数据）

**什么是变量？**
- 变量 = 一个盒子，里面可以装数据
- 给盒子起个名字，以后用名字就能找到它

**定义变量的语法**：
```csharp
数据类型 变量名 = 初始值;

int age = 25;           // 整数（年龄）
float speed = 5.5f;     // 小数（速度，注意要加f）
string name = "Player"; // 字符串（文字）
bool isAlive = true;    // 布尔（真/假）
```

**Unity常用类型**：
| 类型 | 说明 | 示例 |
|------|------|------|
| `int` | 整数 | `int score = 100;` |
| `float` | 小数 | `float speed = 10.5f;` |
| `bool` | 真/假 | `bool canJump = true;` |
| `string` | 文字 | `string playerName = "Hero";` |
| `Vector3` | 三维向量 | `Vector3 pos = new Vector3(0, 1, 0);` |
| `GameObject` | 游戏对象 | `GameObject enemy;` |

**public和private的区别**：
```csharp
public int health = 100;    // public：公开，Inspector可见可修改
private int maxHealth;       // private：私有，只有代码能访问

// protected：子类可以访问
// internal：同一程序集可以访问
```

**练习**：
```csharp
public class VariablesPractice : MonoBehaviour
{
    public int playerLevel = 1;
    public float moveSpeed = 5.0f;
    public string playerName = "勇士";
    public bool hasWeapon = false;
    
    void Start()
    {
        Debug.Log("玩家名字：" + playerName);
        Debug.Log("等级：" + playerLevel);
        Debug.Log("速度：" + moveSpeed);
    }
}
```

把这个脚本挂到对象上，在Inspector修改值，看输出变化。

### 3.4 运算符（数学运算）

**算术运算符**：
```csharp
int a = 10;
int b = 3;

int sum = a + b;      // 13（加法）
int diff = a - b;     // 7（减法）
int product = a * b;  // 30（乘法）
int quotient = a / b; // 3（除法，整数除法会舍去小数）
int remainder = a % b;// 1（取余数：10除以3余1）
```

**复合赋值**：
```csharp
int score = 0;

score = score + 10;  // 老写法
score += 10;         // 新写法（效果一样）

score -= 5;          // 相当于 score = score - 5
score *= 2;          // 相当于 score = score * 2
score /= 2;          // 相当于 score = score / 2
```

**自增自减**：
```csharp
int count = 0;

count++;  // 先使用，后加1
++count;  // 先加1，后使用

count--;  // 先使用，后减1
--count;  // 先减1，后使用
```

### 3.5 条件语句（if/else）

**什么是条件？**
- 让程序根据不同情况做不同的事
- 如果...就...；否则...

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
| 运算符 | 含义 | 示例 | 结果 |
|--------|------|------|------|
| `==` | 等于 | `5 == 5` | true |
| `!=` | 不等于 | `5 != 3` | true |
| `>` | 大于 | `5 > 3` | true |
| `<` | 小于 | `5 < 3` | false |
| `>=` | 大于等于 | `5 >= 5` | true |
| `<=` | 小于等于 | `3 <= 5` | true |

**逻辑运算符**：
```csharp
&&  // 并且（AND）：两边都为真才为真
||  // 或者（OR）：只要一边为真就为真
!   // 非（NOT）：取反

// 示例
if (health > 0 && hasWeapon == true)
{
    // 有生命 并且 有武器
}

if (isDead || time <= 0)
{
    // 死亡了 或者 时间到了
}

if (!isPaused)
{
    // 如果没有暂停
}
```

**完整示例**：
```csharp
public class HealthSystem : MonoBehaviour
{
    public int health = 100;
    
    void Update()
    {
        // 按H键扣血
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            
            // 嵌套if判断
            if (health <= 0)
            {
                Debug.Log("游戏结束！");
            }
            else if (health <= 30)
            {
                Debug.Log("警告：生命值危险！");
            }
            else
            {
                Debug.Log("当前生命：" + health);
            }
        }
        
        // 按R键回血
        if (Input.GetKeyDown(KeyCode.R))
        {
            health = 100;
            Debug.Log("生命值已恢复！");
        }
    }
}
```

### 3.6 循环语句

**for循环**（固定次数）：
```csharp
// 打印0到4
for (int i = 0; i < 5; i++)
{
    Debug.Log("第" + i + "次循环");
}

// 解释：
// int i = 0  → 初始化计数器
// i < 5      → 条件：i小于5时继续
// i++        → 每次循环后i加1
```

**while循环**（条件满足时循环）：
```csharp
int countdown = 3;

while (countdown > 0)
{
    Debug.Log("倒计时：" + countdown);
    countdown--;  // 别忘了减1，否则会无限循环！
}

Debug.Log("发射！");
```

**foreach循环**（遍历集合）：
```csharp
// 假设有一组敌人
GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

foreach (GameObject enemy in enemies)
{
    Debug.Log("找到敌人：" + enemy.name);
}
```

**⚠️ 无限循环警告**：
```csharp
// 错误示例！会导致Unity卡死！
while (true)
{
    Debug.Log("无限循环！");
    // 没有break，永远不会退出
}

// 正确：要有退出条件
while (isGameRunning)
{
    // 游戏逻辑
    if (playerHealth <= 0)
    {
        isGameRunning = false;  // 退出条件
    }
}
```

### 3.7 方法（函数）

**什么是方法？**
- 把一段代码打包，起个名字
- 需要时调用名字就能执行这段代码

**定义方法**：
```csharp
// 返回值类型 方法名(参数列表)
{
// 方法体
// return 返回值;（如果有返回值）
// }

// 示例1：无返回值，无参数
void SayHello()
{
    Debug.Log("你好！");
}

// 示例2：无返回值，有参数
void Greet(string name)
{
    Debug.Log("你好，" + name + "！");
}

// 示例3：有返回值，有参数
int Add(int a, int b)
{
    int sum = a + b;
    return sum;  // 返回计算结果
}
```

**调用方法**：
```csharp
void Start()
{
    SayHello();                    // 输出：你好！
    Greet("小明");                  // 输出：你好，小明！
    
    int result = Add(3, 5);        // result = 8
    Debug.Log("3+5=" + result);    // 输出：3+5=8
}
```

**为什么要用方法？**
1. 代码重用：写一次，多次调用
2. 结构清晰：把复杂逻辑拆分成小块
3. 易于维护：修改一处，处处生效

### 3.8 完整示例：简单玩家控制器

```csharp
using UnityEngine;

public class SimplePlayer : MonoBehaviour
{
    [Header("移动设置")]
    public float moveSpeed = 5f;
    
    [Header("生命设置")]
    public int maxHealth = 100;
    private int currentHealth;
    
    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("游戏开始！当前生命：" + currentHealth);
    }
    
    void Update()
    {
        // 处理移动输入
        HandleMovement();
        
        // 处理受伤输入（测试用）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }
    
    void HandleMovement()
    {
        // 获取输入
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // 创建移动向量
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        
        // 移动物体
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
    
    void TakeDamage(int damage)
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
        Debug.Log("玩家死亡！");
        Destroy(gameObject);  // 销毁自己
    }
}
```

**使用方法**：
1. 创建C#脚本，命名为SimplePlayer
2. 复制上面代码粘贴进去
3. 保存（Ctrl+S）
4. 在Unity中创建一个Cube
5. 把脚本拖到Cube上
6. 点击Play
7. 用WASD移动，按空格扣血

---

## 第4章：游戏对象与组件

### 4.1 游戏对象（GameObject）

**什么是游戏对象？**
- Unity中所有东西的基类
- 场景中的任何东西都是GameObject
- 本身没有功能，靠组件实现功能

**创建游戏对象**：
```csharp
// 在代码中创建
GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

// 实例化预制体
GameObject enemy = Instantiate(enemyPrefab, position, rotation);

// 销毁
Destroy(gameObject);  // 销毁自己
Destroy(enemy, 2f);   // 2秒后销毁enemy
```

### 4.2 组件（Component）

**什么是组件？**
- 附加到游戏对象上的功能模块
- 一个对象可以有多个组件
- 类似乐高积木，拼出不同功能

**常用组件**：
| 组件 | 功能 |
|------|------|
| Transform | 位置、旋转、缩放 |
| Mesh Renderer | 渲染3D模型 |
| Sprite Renderer | 渲染2D精灵 |
| Collider | 碰撞检测 |
| Rigidbody | 物理模拟 |
| Animator | 动画控制 |
| Audio Source | 播放声音 |

**添加/获取组件**：
```csharp
// 添加组件
Rigidbody rb = gameObject.AddComponent<Rigidbody>();

// 获取组件（当前物体）
Rigidbody rb = GetComponent<Rigidbody>();

// 获取组件（其他物体）
Rigidbody rb = otherObject.GetComponent<Rigidbody>();

// 获取子物体的组件
Rigidbody rb = GetComponentInChildren<Rigidbody>();

// 移除组件
Destroy(GetComponent<Rigidbody>());
```

### 4.3 Transform组件详解

**Transform是最重要的组件**，每个对象都有。

**属性**：
```csharp
Transform trans = transform;  // 简写

// 位置
Vector3 pos = trans.position;           // 世界坐标
Vector3 localPos = trans.localPosition; // 本地坐标（相对于父物体）

// 旋转
Quaternion rot = trans.rotation;        // 四元数（专业）
Vector3 euler = trans.eulerAngles;      // 欧拉角（0-360度）

// 缩放
Vector3 scale = trans.localScale;
```

**常用方法**：
```csharp
// 移动
transform.Translate(Vector3.forward * Time.deltaTime);  // 向前移动
transform.position += Vector3.up * 2;                    // 向上移动2单位

// 旋转
transform.Rotate(Vector3.up * 100 * Time.deltaTime);    // 旋转
transform.eulerAngles = new Vector3(0, 90, 0);          // 设置角度

// 朝向目标
transform.LookAt(target);  // 面向目标物体

// 获取方向向量
Vector3 forward = transform.forward;  // 前方
Vector3 right = transform.right;      // 右方
Vector3 up = transform.up;            // 上方
```

### 4.4 预制体（Prefab）

**什么是预制体？**
- 保存为资源的游戏对象
- 可以重复使用
- 修改预制体，所有实例都会更新

**创建预制体**：
1. 在Hierarchy中配置好游戏对象
2. 把它拖到Project窗口
3. 变成蓝色就是预制体了

**使用预制体**：
```csharp
public GameObject enemyPrefab;  // 在Inspector中拖入预制体

void SpawnEnemy()
{
    // 在指定位置生成
    Vector3 spawnPos = new Vector3(0, 0, 10);
    Quaternion spawnRot = Quaternion.identity;  // 无旋转
    
    Instantiate(enemyPrefab, spawnPos, spawnRot);
}
```

**预制体变体（Prefab Variant）**：
- 基于原预制体，但有自己的修改
- 适合创建同一类别的不同变种（如：普通敌人、精英敌人）

---

## 第5章：物理系统

### 5.1 Rigidbody（刚体）

**什么是Rigidbody？**
- 让物体受物理影响的组件
- 受重力、可以被撞飞、可以施加力

**添加Rigidbody**：
1. 选中物体
2. Inspector → Add Component
3. 搜索"Rigidbody"添加

**重要属性**：
| 属性 | 说明 |
|------|------|
| Mass | 质量（千克） |
| Drag | 空气阻力 |
| Use Gravity | 是否受重力影响 |
| Is Kinematic | 是否不受物理控制（用代码控制位置时勾选） |
| Constraints | 冻结某个轴的位置/旋转 |

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

### 5.2 Collider（碰撞器）

**什么是Collider？**
- 定义物体的碰撞形状
- 没有Collider就不会有碰撞检测

**常见类型**：
| 类型 | 形状 |
|------|------|
| Box Collider | 盒子 |
| Sphere Collider | 球体 |
| Capsule Collider | 胶囊 |
| Mesh Collider | 跟随模型形状（性能消耗大） |

**重要属性**：
- **Is Trigger**：勾选后变成触发器（可以穿透，但能检测到接触）

### 5.3 碰撞检测

**两种检测方式**：

**1. 物理碰撞（Collision）**
- 两个物体都有Collider
- 至少一个有Rigidbody
- 都不能勾选Is Trigger

```csharp
// 碰撞开始
void OnCollisionEnter(Collision collision)
{
    Debug.Log("撞到了：" + collision.gameObject.name);
}

// 持续碰撞
void OnCollisionStay(Collision collision) { }

// 碰撞结束
void OnCollisionExit(Collision collision) { }
```

**2. 触发器碰撞（Trigger）**
- 至少一个Collider勾选了Is Trigger
- 可以穿透，但能检测到接触

```csharp
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Coin"))
    {
        CollectCoin(other.gameObject);
    }
}
```

### 5.4 射线检测（Raycast）

**用途**：从某点发射一条线，检测碰到的物体

```csharp
// 从屏幕中心发射射线
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
RaycastHit hit;

if (Physics.Raycast(ray, out hit, 100f))
{
    Debug.Log("射线击中了：" + hit.collider.name);
    Debug.Log("击中点坐标：" + hit.point);
}
```

**常用场景**：
- FPS射击检测
- 点击地面移动
- 瞄准

---

## 第6章：2D游戏基础

### 6.1 2D vs 3D

**切换项目类型**：
- 创建项目时选择"2D"模板
- 或在3D项目中：
  - Edit → Project Settings → Graphics
  - 修改渲染管线

**2D专用组件**：
- Sprite Renderer（代替Mesh Renderer）
- Rigidbody2D
- Collider2D（BoxCollider2D, CircleCollider2D等）

### 6.2 Sprite（精灵）

**导入图片为Sprite**：
1. 把图片拖到Project窗口
2. 选中图片
3. Inspector中：
   - Texture Type → Sprite (2D and UI)
   - 点击Apply

**Sprite Renderer属性**：
- Sprite：显示的图片
- Color：颜色叠加
- Flip X/Y：翻转
- Sorting Layer：渲染层级（决定谁在前面）

### 6.3 2D物理

**Rigidbody2D**：
```csharp
Rigidbody2D rb = GetComponent<Rigidbody2D>();

// 添加力
rb.AddForce(Vector2.up * 500);

// 设置速度
rb.velocity = new Vector2(5, rb.velocity.y);

// 冻结旋转（防止角色翻滚）
rb.freezeRotation = true;

// 重力缩放（0=无重力，1=正常重力，2=两倍重力）
rb.gravityScale = 1;
```

**2D碰撞检测**：
```csharp
void OnCollisionEnter2D(Collision2D collision) { }
void OnTriggerEnter2D(Collider2D other) { }
```

### 6.4 地面检测

```csharp
public class Player2D : MonoBehaviour
{
    public float jumpForce = 10f;
    public Transform groundCheck;  // 地面检测点（空物体，放在脚底）
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;  // 地面图层
    
    private bool isGrounded;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // 检测地面
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        // 跳跃
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    // 可视化地面检测范围
    void OnDrawGizmos()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
```

---

## 第7章：动画系统

### 7.1 Animator基础

**创建动画**：
1. 选中带Sprite Renderer的对象
2. Window → Animation → Animation
3. 点击Create，保存动画文件
4. 把多张Sprite拖到时间轴上
5. 调整每帧时长（ Samples = 每秒帧数）

**创建Animator Controller**：
1. Project窗口右键 → Create → Animator Controller
2. 拖到对象的Animator组件上
3. 双击打开Animator窗口

### 7.2 动画状态机

**基本概念**：
- **State（状态）**：一个动画片段（如Idle、Run、Jump）
- **Transition（过渡）**：从一个状态到另一个状态的切换
- **Parameter（参数）**：控制状态切换的变量

**常用参数类型**：
- Float：浮点数（如移动速度）
- Int：整数（如武器类型）
- Bool：布尔值（如是否在地面上）
- Trigger：触发器（如攻击触发一次）

**代码控制**：
```csharp
Animator animator = GetComponent<Animator>();

// 设置参数
animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
animator.SetBool("IsGrounded", isGrounded);
animator.SetTrigger("Attack");
animator.SetInteger("WeaponType", 1);

// 获取参数
float speed = animator.GetFloat("Speed");
```

### 7.3 动画事件

**用途**：在动画的特定帧调用方法（如攻击动画的第5帧造成伤害）

**使用方法**：
1. 打开Animation窗口
2. 找到要添加事件的帧
3. 点击"Add Event"按钮
4. 选择要调用的方法

---

## 第8章：UI系统

### 8.1 Canvas（画布）

**创建UI**：
- Hierarchy右键 → UI → Canvas

**渲染模式**：
| 模式 | 说明 |
|------|------|
| Screen Space - Overlay | UI显示在所有物体上面（2D游戏常用） |
| Screen Space - Camera | UI跟随指定相机 |
| World Space | UI在3D世界中（如游戏中电脑屏幕） |

### 8.2 常用UI元素

**创建方式**：Hierarchy右键 → UI

| 元素 | 用途 |
|------|------|
| Text | 显示文字（旧版） |
| TextMeshPro | 显示文字（新版，效果更好） |
| Image | 显示图片 |
| Button | 按钮 |
| Slider | 滑条（如血条） |
| Input Field | 输入框 |

### 8.3 代码控制UI

```csharp
using UnityEngine;
using UnityEngine.UI;  // UI命名空间

public class UIManager : MonoBehaviour
{
    public Text scoreText;      // 拖入Text组件
    public Slider healthBar;    // 拖入Slider组件
    public Button restartButton;
    
    void Start()
    {
        // 按钮点击事件
        restartButton.onClick.AddListener(RestartGame);
    }
    
    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
    
    public void UpdateHealthBar(float current, float max)
    {
        healthBar.value = current / max;
    }
    
    void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
```

---

## 第9章：阶段一综合项目

### 9.1 项目需求：2D平台跳跃游戏

**功能清单**：
- [x] 角色左右移动
- [x] 跳跃（可二段跳）
- [x] 地面检测
- [x] 收集金币
- [x] 碰到敌人扣血
- [x] 生命值系统
- [x] 分数显示
- [x] 游戏结束/重新开始

### 9.2 完整代码

**PlayerController2D.cs**：
```csharp
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
    
    private Rigidbody2D rb;
    private Animator animator;
    private int currentHealth;
    private int jumpsRemaining;
    private bool facingRight = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        // 地面检测
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        
        if (isGrounded)
        {
            jumpsRemaining = maxJumps;
        }
        
        // 跳跃
        if (Input.GetButtonDown("Jump") && jumpsRemaining > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpsRemaining--;
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
        
        // 翻转
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
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            GameManager.Instance.AddScore(10);
        }
        else if (other.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}
```

---

# 附录

## 附录A：完整代码库

### A.1 单例模式模板
```csharp
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    
    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

// 使用
public class GameManager : Singleton<GameManager>
{
    // 你的代码
}
```

### A.2 对象池
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
        
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    
    public GameObject Get()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        return Instantiate(prefab);
    }
    
    public void Return(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
```

## 附录B：常见问题100问

**Q1：代码保存后Unity不更新？**
A：回到Unity窗口，它会自动编译。如果报错，看Console的错误信息。

**Q2：Inspector不显示我的变量？**
A：只有public变量才会显示。或者变量类型不支持（如List需要加[SerializeField]）。

**Q3：游戏对象找不到？**
A：检查Tag是否正确，或者使用transform.Find("子物体名")查找子物体。

**Q4：Rigidbody不生效？**
A：检查是否添加了Collider，是否勾选了Is Kinematic。

**Q5：碰撞检测不触发？**
A：检查：1)双方都有Collider 2)至少一方有Rigidbody 3)代码方法名拼写正确。

**Q6：动画不播放？**
A：检查：1)Animator Controller是否正确赋值 2)参数名是否一致 3)状态是否有过渡。

**Q7：UI不显示？**
A：检查Canvas的渲染模式，或者UI元素是否在Camera视野外。

**Q8：怎么发布游戏？**
A：File → Build Settings → 选择平台 → Build。

**Q9：游戏运行时很卡？**
A：可能是：1)太多物体 2)复杂物理计算 3)没使用对象池 4)draw call太多。

**Q10：怎么学习Shader？**
A：先掌握基础，然后学Shader Graph（可视化），最后再学手写Shader代码。

（更多问题...）

## 附录C：自测题与答案

**C#基础测试**：

1. `int a = 5 / 2;` a的值是多少？
   答案：2（整数除法舍去小数）

2. `float b = 5 / 2;` b的值是多少？
   答案：2.0（先整数除法得2，再转float）

3. `float c = 5.0f / 2;` c的值是多少？
   答案：2.5（浮点数除法）

4. `bool result = (3 > 2) && (5 < 3);` result的值？
   答案：false（true && false = false）

**Unity基础测试**：

1. Update和FixedUpdate的区别？
   答案：Update每帧调用，FixedUpdate固定时间调用（用于物理）。

2. 为什么有时用transform.position，有时用rb.MovePosition？
   答案：直接改position会穿透物体，MovePosition有插值更平滑。

3. OnCollisionEnter和OnTriggerEnter的区别？
   答案：Collision是物理碰撞（会阻挡），Trigger是触发器（可穿透）。

## 附录D：快捷键大全

**场景操作**：
- Q：手型工具（平移视图）
- W：移动工具
- E：旋转工具
- R：缩放工具
- F：聚焦选中物体
- Ctrl + D：复制物体

**播放控制**：
- Ctrl + P：播放/停止
- Ctrl + Shift + P：暂停
- Ctrl + Alt + P：逐帧前进

**窗口**：
- Ctrl + 1：Scene视图
- Ctrl + 2：Game视图
- Ctrl + 6：Animation窗口
- Ctrl + 9：Console窗口

---

**文档结束**

**下一步**：打开Unity，创建一个2D项目，开始实践第9章的综合项目！

**遇到问题**：
1. 先检查代码拼写
2. 看Console的错误信息
3. 对照本文档的示例代码
4. 如果还解决不了，记录下来，学完基础后再回头看

**祝学习顺利！**
