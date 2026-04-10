using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public int totalCoins = 12;
    private int collectedCoins = 0;
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void CollectCoin()
    {
        collectedCoins++;
        Debug.Log($"收集进度: {collectedCoins}/{totalCoins}");
        
        if (collectedCoins >= totalCoins)
        {
            WinGame();
        }
    }
    
    void WinGame()
    {
        Debug.Log("🎉 恭喜！你收集了所有金币！");
        // 这里可以显示胜利UI或加载下一关
    }
}