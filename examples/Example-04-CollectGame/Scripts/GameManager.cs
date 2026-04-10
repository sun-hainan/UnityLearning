using UnityEngine;
using UnityEngine.SceneManagement;

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
        Debug.Log(string.Format("收集进度: {0}/{1}", collectedCoins, totalCoins));
        
        if (collectedCoins >= totalCoins)
        {
            WinGame();
        }
    }
    
    void WinGame()
    {
        Debug.Log("恭喜！你收集了所有金币！");
    }
    
    public void ResetGame()
    {
        collectedCoins = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
