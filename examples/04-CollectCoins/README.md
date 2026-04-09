# 04-CollectCoins

## 功能
收集金币，计分显示

## 学习点
- 触发器碰撞（OnTriggerEnter）
- UI 系统（Text）
- 销毁对象
- 单例模式

## 代码

### PlayerController.cs
```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += new Vector3(h, 0, v) * speed * Time.deltaTime;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.Instance.AddScore(10);
            Destroy(other.gameObject);
        }
    }
}
```

### GameManager.cs
```csharp
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = $"Score: {score}";
    }
}
```

## 步骤

1. 创建玩家（添加触发器Collider）
2. 创建金币预制体（Sphere + Trigger）
3. 创建 UI Canvas，添加 Text
4. 创建 GameManager
5. 放置多个金币
6. 运行收集

## 练习

- [ ] 添加金币旋转动画
- [ ] 收集金币时播放音效
- [ ] 添加计时功能
