using UnityEngine;

public class GameManager2D : MonoBehaviour
{
    public static GameManager2D Instance { get; private set; }
    
    private int score = 0;
    
    void Awake()
    {
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
    
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("当前分数：" + score);
    }
    
    public int GetScore()
    {
        return score;
    }
}
