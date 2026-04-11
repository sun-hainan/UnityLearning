using UnityEngine;

/// <summary>
/// Flappy Bird - 鸟类控制器
/// 功能：点击/空格键跳跃，检测碰撞
/// </summary>
public class BirdController : MonoBehaviour
{
    [Header("移动设置")]
    public float jumpForce = 5f;
    public float rotationSpeed = 5f;
    public float maxRotation = 45f;
    public float minRotation = -90f;
    
    [Header("组件")]
    private Rigidbody2D rb;
    private Animator animator;
    
    [Header("状态")]
    private bool isDead = false;
    private bool isStarted = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
        // 开始时冻结，等待玩家操作
        rb.gravityScale = 0;
    }
    
    void Update()
    {
        if (isDead) return;
        
        // 检测跳跃输入（点击鼠标或按空格）
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (!isStarted)
            {
                StartGame();
            }
            Jump();
        }
        
        // 根据速度调整旋转
        RotateBird();
    }
    
    /// <summary>
    /// 开始游戏
    /// </summary>
    void StartGame()
    {
        isStarted = true;
        rb.gravityScale = 1;
        
        // 通知游戏管理器开始生成管道
        FindObjectOfType<PipeSpawner>()?.StartSpawning();
    }
    
    /// <summary>
    /// 跳跃
    /// </summary>
    void Jump()
    {
        // 重置速度再施加力（避免多次跳跃力叠加）
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
        // 播放动画
        animator?.SetTrigger("Flap");
    }
    
    /// <summary>
    /// 根据速度旋转鸟
    /// </summary>
    void RotateBird()
    {
        float velocityY = rb.velocity.y;
        float targetRotation = Mathf.Lerp(maxRotation, minRotation, Mathf.InverseLerp(2, -5, velocityY));
        
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            Quaternion.Euler(0, 0, targetRotation),
            rotationSpeed * Time.deltaTime
        );
    }
    
    /// <summary>
    /// 碰撞检测
    /// </summary>
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead)
        {
            Die();
        }
    }
    
    /// <summary>
    /// 触发器检测（通过管道得分）
    /// </summary>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (isDead) return;
        
        if (other.CompareTag("ScoreZone"))
        {
            GameManager.Instance.AddScore(1);
            Debug.Log("✅ 得分！");
        }
    }
    
    /// <summary>
    /// 死亡
    /// </summary>
    void Die()
    {
        isDead = true;
        rb.velocity = Vector2.zero;
        
        animator?.SetTrigger("Die");
        GameManager.Instance.GameOver();
    }
}