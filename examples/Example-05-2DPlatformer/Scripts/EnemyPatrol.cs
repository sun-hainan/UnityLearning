using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public float patrolDistance = 3f;
    
    private Vector3 startPosition;
    private bool movingRight = true;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        Patrol();
    }
    
    void Patrol()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * patrolSpeed * Time.deltaTime;
            if (transform.position.x >= startPosition.x + patrolDistance)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.position += Vector3.left * patrolSpeed * Time.deltaTime;
            if (transform.position.x <= startPosition.x - patrolDistance)
            {
                movingRight = true;
                Flip();
            }
        }
    }
    
    void Flip()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        else
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}
