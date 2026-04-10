using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController2D : MonoBehaviour
{
    [Header("移动设置")]
    public float moveSpeed = 5f;
    
    [Header("跳跃设置")]
    public float jumpForce = 10f;
    public int maxJumps = 2;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    
    [Header("生命设置")]
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
        
        // 重置关卡
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetLevel();
        }
        
        // 更新动画参数
        UpdateAnimator();
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
    }
    
    void Jump()
    {
        // 重置垂直速度（实现一致跳跃高度）
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        jumpsRemaining--;
        
        // 触发跳跃动画
        if (animator != null)
        {
            animator.SetTrigger("Jump");
        }
        
        Debug.Log("跳跃！剩余次数：" + jumpsRemaining);
    }
    
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    
    void UpdateAnimator()
    {
        if (animator == null) return;
        
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(move));
        animator.SetBool("IsGrounded", isGrounded);
        animator.SetFloat("VerticalVelocity", rb.velocity.y);
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("受到伤害！剩余生命：" + currentHealth);
        
        // 受伤闪烁效果
        StartCoroutine(DamageFlash());
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    System.Collections.IEnumerator DamageFlash()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            sr.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            sr.color = Color.white;
        }
    }
    
    void Die()
    {
        Debug.Log("游戏结束！");
        ResetLevel();
    }
    
    void ResetLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("获得金币！");
            
            // 通知GameManager
            if (GameManager2D.Instance != null)
            {
                GameManager2D.Instance.AddScore(10);
            }
        }
        else if (other.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
        else if (other.CompareTag("KillZone"))
        {
            Die();
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
