# UnityLearning 截图与GIF指南

> 📸 **说明**：本目录用于存放教程的可视化演示材料

---

## 目录结构

```
images/
├── 01-环境搭建/
│   ├── unity-install.png          # Unity Hub安装界面
│   ├── create-project.png         # 创建新项目
│   └── scene-view.png             # Scene视图介绍
├── 02-第一个脚本/
│   ├── create-script.gif          # 创建C#脚本步骤
│   ├── attach-component.gif       # 附加组件到GameObject
│   └── play-mode.gif              # 运行游戏查看效果
├── 03-基础概念/
│   ├── transform-gizmo.gif        # Transform工具演示
│   ├── rigidbody-fall.gif         # 物理下落效果
│   └── collision-demo.gif         # 碰撞检测演示
└── 04-小游戏实战/
    ├── roll-ball-gameplay.gif     # 滚球游戏演示
    ├── flappy-bird-gameplay.gif   # Flappy Bird演示
    └── jump-game-gameplay.gif     # 跳跃游戏演示
```

---

## 截图规范

| 类型 | 分辨率 | 格式 | 说明 |
|-----|--------|------|------|
| 静态截图 | 1920x1080 | PNG | 界面说明、代码高亮 |
| 操作演示 | 1280x720 | GIF | 步骤演示，< 5MB |
| 游戏演示 | 1280x720 | GIF | 实际运行效果，< 10MB |

---

## 截图工具推荐

### Windows
- **ShareX** (免费) - 截图+录屏+GIF生成
- **ScreenToGif** (免费) - 专门制作GIF
- **Snipaste** (免费) - 截图标注

### Mac
- **CleanShot X** (付费) - 功能全面
- **Kap** (免费) - 开源录屏转GIF

---

## 如何添加截图

1. 在对应模块目录下创建图片
2. 在教程文档中引用：
   ```markdown
   ![描述](./images/01-环境搭建/unity-install.png)
   ```
3. 提交到GitHub

---

## 占位符说明

当前截图为空，等待社区贡献：

- [ ] 01-环境搭建截图
- [ ] 02-第一个脚本GIF
- [ ] 03-基础概念演示
- [ ] 04-小游戏实录

---

> 💡 **提示**：如果你想贡献截图，请确保：
> 1. 使用 Unity 2022.3 LTS 或团结引擎 1.8.x
> 2. 界面语言为简体中文或英文
> 3. 不包含个人信息或敏感内容
