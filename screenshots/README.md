# 🖼️ 项目截图与演示指南

> 本仓库使用截图和GIF来增强教程的可读性和直观性。

---

## 📸 截图清单

### 1. Unity编辑器界面截图

| 截图名称 | 用途 | 拍摄位置 |
|---------|------|---------|
| `unity-interface.png` | 展示Unity主界面 | README.md |
| `scene-view.png` | Scene窗口说明 | 完整自学指南.md |
| `game-view.png` | Game窗口说明 | 完整自学指南.md |
| `inspector.png` | Inspector组件面板 | 完整自学指南.md |

**拍摄建议：**
- 分辨率：1920x1080 或 2560x1440
- 标注：用红色/黄色框圈出关键区域
- 箭头：指向重要按钮或菜单

---

### 2. 项目示例截图

| 截图名称 | 用途 | 来源项目 |
|---------|------|---------|
| `2d-shootemup-gameplay.png` | 2D射击游戏实际画面 | 02-2DShootEmUp |
| `rts-gameplay.png` | RTS策略游戏画面 | 03-RTS-Strategy |
| `hacknslash-gameplay.png` | 动作RPG游戏画面 | 04-HacknSlash |

---

### 3. GIF动图

| GIF名称 | 用途 | 录制内容 |
|--------|------|---------|
| `player-movement.gif` | 演示玩家移动控制 | WASD移动角色 |
| `shooting-demo.gif` | 演示射击系统 | 发射子弹、击中敌人 |
| `building-placement.gif` | 演示建筑放置 | RTS模式下的建造 |
| `combo-attack.gif` | 演示连招系统 | 连续攻击动作 |

**录制工具推荐：**
- Windows: ShareX (免费) 或 ScreenToGif
- Mac: Gifski 或 LICEcap

**GIF规格：**
- 宽度：800px (保持比例)
- 帧率：15-30fps
- 时长：3-10秒
- 大小：尽量 < 5MB

---

## 🎨 截图标注规范

### 颜色使用

| 颜色 | 用途 |
|------|------|
| 🔴 红色 | 错误、警告、危险操作 |
| 🟢 绿色 | 正确、成功、推荐操作 |
| 🟡 黄色 | 重点、注意、关键区域 |
| 🔵 蓝色 | 可选、提示、补充信息 |

### 标注元素

```
┌─────────────────────────────────────┐
│  [1]  ← 数字标注，对应说明文字       │
│    ╔═══════════════╗                │
│    ║  关键区域     ║ ← 高亮框       │
│    ╚═══════════════╝                │
│  文字说明 → 解释当前操作            │
└─────────────────────────────────────┘
```

---

## 📂 截图存放位置

```
UnityLearning/
├── imgs/                          # 静态图片
│   ├── logo.png                   # 仓库Logo
│   ├── unity-interface.png        # Unity界面
│   ├── project-showcase/          # 项目展示
│   │   ├── 2d-shootemup/
│   │   │   ├── gameplay.png
│   │   │   └── enemy-types.png
│   │   ├── rts-strategy/
│   │   │   └── gameplay.png
│   │   └── hacknslash/
│   │       └── combat-system.png
│   └── tutorials/                 # 教程配图
│       ├── chapter1/
│       ├── chapter2/
│       └── ...
├── gifs/                          # 动态演示
│   ├── player-movement.gif
│   ├── shooting-demo.gif
│   └── ...
└── screenshots/                   # 说明文档
    └── README.md                  # 本文件
```

---

## 📝 截图制作指南

### 1. Unity界面截图

**步骤：**
1. 打开Unity项目
2. 按 `Ctrl + Shift + F` 调整布局为 Default
3. 隐藏不必要的窗口（只保留 Scene/Game/Hierarchy/Inspector）
4. 按 `F` 聚焦要展示的对象
5. 使用系统截图工具：`Win + Shift + S`
6. 粘贴到画图工具，添加标注
7. 保存为 PNG 格式

### 2. 游戏运行截图

**步骤：**
1. 点击 Play 运行游戏
2. 调整到最佳展示状态
3. 按 `F12` 或使用截图工具
4. 确保画面清晰、内容完整

### 3. GIF录制

**ShareX设置：**
```
Task Settings → Capture → Screen recorder
- FPS: 15
- Video codec: gif
- Quality: 80%
- Capture mouse cursor: Yes
```

**录制技巧：**
- 预先演练3-5次，确保动作流畅
- 录制前清理桌面，避免干扰
- 使用固定大小的录制区域
- 录制后裁剪开头和结尾的停顿

---

## 🔗 在文档中引用

### Markdown格式

```markdown
<!-- 图片 -->
![Unity界面](imgs/unity-interface.png)

<!-- 带标题的图片 -->
<figure>
  <img src="imgs/gameplay.png" width="800" />
  <figcaption>图1：游戏实际运行画面</figcaption>
</figure>

<!-- GIF动图 -->
![玩家移动演示](gifs/player-movement.gif)

<!-- 缩略图链接大图 -->
[<img src="imgs/thumbnail.png" width="400">](imgs/fullsize.png)
```

### HTML格式（更多控制）

```html
<!-- 居中显示 -->
<p align="center">
  <img src="imgs/demo.gif" width="600" alt="演示" />
</p>

<!-- 并排显示 -->
<p align="center">
  <img src="imgs/before.png" width="400" />
  <img src="imgs/after.png" width="400" />
</p>
<p align="center">
  <em>左：修改前 | 右：修改后</em>
</p>
```

---

## ✅ 截图检查清单

在上传截图前，请确认：

- [ ] 图片格式为 PNG（静态）或 GIF（动态）
- [ ] 文件大小 < 5MB（GIF < 10MB）
- [ ] 分辨率合适（不要太小或太大）
- [ ] 已添加必要的标注和说明
- [ ] 没有敏感信息（个人路径、账号等）
- [ ] 文件名使用英文，用连字符分隔
- [ ] 图片已压缩（可用 TinyPNG）

---

## 🚀 快速开始

### 为README添加项目Logo

1. 打开 Unity
2. 创建一个新场景
3. 添加一个 Canvas → Image
4. 设计Logo（或使用在线工具如 Canva）
5. 截图保存为 `imgs/logo.png`
6. 在 README.md 中添加：

```markdown
<p align="center">
  <img src="imgs/logo.png" width="200" alt="Unity Learning">
</p>
```

### 为教程添加步骤截图

1. 打开对应章节的项目
2. 按步骤操作到关键位置
3. 截图并添加编号标注
4. 保存到 `imgs/tutorials/chapterX/`
5. 在文档中引用

---

**最后更新**：2026年4月10日  
**维护者**：UnityLearning团队
