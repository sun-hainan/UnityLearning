using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public float patrolDistance = 3f;
    
    private Vector3 startPosition;
    private bool movingRight = true;
    
    void Start()
    {
        startPosition = transform.position;
    }
    
    void Update()
    {
        // 巡逻移动
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
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
