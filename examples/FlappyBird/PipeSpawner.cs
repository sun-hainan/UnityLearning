using UnityEngine;

/// <summary>
/// 管道生成器
/// 功能：定时生成管道，控制游戏难度
/// </summary>
public class PipeSpawner : MonoBehaviour
{
    [Header("管道预制体")]
    public GameObject pipePrefab;
    
    [Header("生成设置")]
    public float spawnRate = 2f;           // 生成间隔
    public float heightOffset = 1.5f;      // 高度随机范围
    public float minHeight = -2f;          // 最低位置
    public float maxHeight = 2f;           // 最高位置
    public float pipeGap = 3f;             // 管道间距
    
    [Header("难度递增")]
    public float difficultyIncrease = 0.95f;  // 生成间隔缩减系数
    public float minSpawnRate = 1f;           // 最小生成间隔
    
    private float timer = 0f;
    private bool isSpawning = false;
    
    void Update()
    {
        if (!isSpawning) return;
        
        timer += Time.deltaTime;
        
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
            
            // 逐渐增加难度
            spawnRate = Mathf.Max(minSpawnRate, spawnRate * difficultyIncrease);
        }
    }
    
    /// <summary>
    /// 开始生成
    /// </summary>
    public void StartSpawning()
    {
        isSpawning = true;
        timer = spawnRate;  // 立即生成第一个
    }
    
    /// <summary>
    /// 停止生成
    /// </summary>
    public void StopSpawning()
    {
        isSpawning = false;
    }
    
    /// <summary>
    /// 生成管道
    /// </summary>
    void SpawnPipe()
    {
        // 随机高度
        float randomY = Random.Range(minHeight, maxHeight);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
        
        // 实例化管道
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
        
        Debug.Log($"🚧 生成管道，高度: {randomY:F2}");
    }
}