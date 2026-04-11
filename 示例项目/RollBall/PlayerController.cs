using UnityEngine;

/// <summary>
/// 滚球游戏 - 玩家控制器
/// 功能：使用键盘方向键或WASD控制球移动
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("移动设置")]
    [Tooltip("球的移动速度")]
    public float speed = 10f;
    
    [Header("组件引用")]
    private Rigidbody rb;
    
    // 初始化
    void Start()
    {
        // 获取刚体组件
        rb = GetComponent<Rigidbody>();
        
        if (rb == null)
        {
            Debug.LogError("❌ 未找到 Rigidbody 组件！请添加刚体组件。");
        }
    }
    
    // 物理更新
    void FixedUpdate()
    {
        // 获取输入
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // 创建力向量
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        // 施加力
        rb.AddForce(movement * speed);
    }
    
    // 碰撞检测 - 收集物品
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            // 销毁收集物
            other.gameObject.SetActive(false);
            
            // 通知游戏管理器
            GameManager.Instance.AddScore(1);
            
            Debug.Log("✅ 收集物品！当前分数：" + GameManager.Instance.GetScore());
        }
    }
}
