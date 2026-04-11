using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 游戏管理器（单例模式）
/// 功能：管理游戏状态、分数、场景切换
/// </summary>
public class GameManager : MonoBehaviour
{
    // 单例实例
    public static GameManager Instance { get; private set; }
    
    [Header("游戏状态")]
    private int score = 0;
    private bool isGameOver = false;
    
    [Header("组件引用")]
    public UIManager uiManager;
    
    // 属性
    public int Score => score;
    public bool IsGameOver => isGameOver;
    
    void Awake()
    {
        // 单例模式实现
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        // 初始化游戏
        score = 0;
        isGameOver = false;
        
        if (uiManager != null)
        {
            uiManager.UpdateScoreText(score);
        }
    }
    
    /// <summary>
    /// 添加分数
    /// </summary>
    public void AddScore(int points)
    {
        if (isGameOver) return;
        
        score += points;
        uiManager?.UpdateScoreText(score);
        
        // 胜利条件检查（收集所有物品）
        CheckWinCondition();
    }
    
    /// <summary>
    /// 获取当前分数
    /// </summary>
    public int GetScore()
    {
        return score;
    }
    
    /// <summary>
    /// 游戏结束
    /// </summary>
    public void GameOver()
    {
        if (isGameOver) return;
        
        isGameOver = true;
        uiManager?.ShowGameOverScreen();
        
        Debug.Log("💀 游戏结束！最终分数: " + score);
    }
    
    /// <summary>
    /// 检查胜利条件
    /// </summary>
    void CheckWinCondition()
    {
        // 查找场景中剩余的收集物
        GameObject[] pickups = GameObject.FindGameObjectsWithTag("PickUp");
        int activePickups = 0;
        
        foreach (var pickup in pickups)
        {
            if (pickup.activeInHierarchy)
                activePickups++;
        }
        
        // 如果没有剩余收集物，游戏胜利
        if (activePickups == 0)
        {
            Win();
        }
    }
    
    /// <summary>
    /// 游戏胜利
    /// </summary>
    void Win()
    {
        isGameOver = true;
        uiManager?.ShowWinScreen(score);
        
        Debug.Log("🎉 恭喜通关！最终分数: " + score);
    }
    
    /// <summary>
    /// 重新开始当前场景
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    /// <summary>
    /// 加载指定场景
    /// </summary>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    /// <summary>
    /// 退出游戏
    /// </summary>
    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}