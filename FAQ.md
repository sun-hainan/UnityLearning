# ❓ 常见问题 FAQ

Unity 学习过程中常见的问题及解决方案。

---

## 🔧 安装问题

### Q1: Unity Hub 打不开或卡在加载界面？
**解决方案：**
1. 检查网络连接（Unity 需要联网验证）
2. 关闭代理/VPN 再试
3. 以管理员身份运行 Unity Hub
4. 清除缓存：`C:\Users\[用户名]\AppData\Roaming\UnityHub`
5. 重新安装 Unity Hub

### Q2: 下载 Unity 编辑器速度很慢？
**解决方案：**
1. 使用 Unity 中国版（unity.cn）
2. 切换网络环境（手机热点试试）
3. 夜间或凌晨下载（网络拥堵少）
4. 使用下载工具的多线程功能

### Q3: 安装时提示 "无法访问路径"？
**解决方案：**
1. 路径不要包含中文或特殊字符
2. 检查磁盘空间是否充足
3. 关闭杀毒软件再试
4. 以管理员身份运行安装程序

---

## 📝 脚本问题

### Q4: 脚本无法挂载到 GameObject？
**可能原因：**
1. 类名和文件名不一致
2. 脚本有编译错误（看 Console 窗口红色错误）
3. 类没有继承 MonoBehaviour

**解决方案：**
```csharp
// 确保类名和文件名完全一致
public class MyScript : MonoBehaviour  // 必须继承 MonoBehaviour
{
    // 代码...
}
```

### Q5: public 变量在 Inspector 中不显示？
**解决方案：**
1. 检查脚本是否有编译错误
2. 使用 `[SerializeField]` 替代 public
3. 重新保存脚本，回到 Unity 等待编译

```csharp
// 方式1：public
public int health = 100;

// 方式2：SerializeField（推荐）
[SerializeField] private int health = 100;
```

### Q6: Debug.Log 不输出？
**解决方案：**
1. 打开 Console 窗口（Window → General → Console）
2. 检查右上角是否勾选了 "Collapse"
3. 清除过滤器，确保没有过滤掉日志
4. 检查脚本是否已挂载并启用

---

## 🎮 运行问题

### Q7: 游戏运行时修改的参数没有保存？
**这是正常行为！**
- 运行时修改的值不会保存
- 停止运行后才能修改并保存
- 或者使用 `[SerializeField]` 并在运行时记录值

### Q8: 角色穿过地面？
**检查清单：**
- [ ] 角色有 Rigidbody（2D 项目用 Rigidbody2D）
- [ ] 地面有 Collider（2D 项目用 Collider2D）
- [ ] 没有勾选 Is Trigger
- [ ] Rigidbody 的 Use Gravity 已勾选

### Q9: 碰撞检测不触发？
**检查清单：**
- [ ] 两个物体都有 Collider
- [ ] 至少一个物体有 Rigidbody（Is Kinematic 也可以）
- [ ] 如果是 Trigger，使用 OnTriggerEnter，否则用 OnCollisionEnter
- [ ] 检查 Tag 是否正确

```csharp
// 普通碰撞（都不勾选 Is Trigger）
void OnCollisionEnter(Collision collision) { }

// 触发碰撞（至少一个勾选 Is Trigger）
void OnTriggerEnter(Collider other) { }
```

---

## 🎨 显示问题

### Q10: Sprite 显示模糊？
**解决方案：**
1. 选中 Sprite，Inspector 中
2. Filter Mode 改为 Point（无过滤）
3. Compression 改为 None

### Q11: 2D 游戏中角色显示在背景后面？
**解决方案：**
1. 修改 Sorting Layer
2. 或修改 Order in Layer（数值大的在前面）

### Q12: UI 按钮点击没反应？
**检查清单：**
- [ ] Canvas 有 Graphic Raycaster 组件
- [ ] 场景中有 EventSystem
- [ ] 按钮的交互已启用（Interactable）
- [ ] 检查是否有其他 UI 遮挡

---

## 🔊 其他问题

### Q13: 游戏打包后运行不了？
**检查清单：**
- [ ] 场景已添加到 Build Settings（File → Build Settings）
- [ ] 脚本没有编译错误
- [ ] 资源路径没有使用绝对路径
- [ ] 平台设置正确（Windows/Mac/Android）

### Q14: 如何找到丢失的 GameObject？
**解决方案：**
```csharp
// 通过名称查找
GameObject player = GameObject.Find("Player");

// 通过标签查找
GameObject enemy = GameObject.FindWithTag("Enemy");

// 通过类型查找
PlayerController pc = FindObjectOfType<PlayerController>();
```

### Q15: 运行时出现 NullReferenceException？
**含义：** 尝试访问空对象的属性或方法

**常见原因：**
1. 忘记给 public 变量赋值
2. Find 方法没找到对象
3. GetComponent 返回 null

**解决方案：**
```csharp
void Start()
{
    // 添加空值检查
    if (target == null)
    {
        Debug.LogError("target 未赋值！");
        return;
    }
}
```

---

## 💡 学习建议

**遇到报错时：**
1. 仔细阅读错误信息（双击 Console 中的错误）
2. 搜索错误关键词 + "Unity"
3. 检查最近修改的代码
4. 使用 Debug.Log 打印变量值

**寻求帮助的渠道：**
- Unity 官方文档：docs.unity3d.com
- Unity 中文课堂：learn.u3d.cn
- Stack Overflow：stackoverflow.com/questions/tagged/unity3d
- 各种 Unity 学习 QQ 群/Discord

---

**最后更新**：2026年4月10日
