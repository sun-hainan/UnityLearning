using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI管理器
/// 功能：管理所有UI元素的显示和更新
/// </summary>
public class UIManager : MonoBehaviour
{
    [Header("UI元素")]
    public Text scoreText;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public Text finalScoreText;
    
    void Start()
    {
        // 初始化UI
        UpdateScoreText(0);
        gameOverPanel.SetActive(false);
        winPanel.SetActive(false);
    }
    
    /// <summary>
    /// 更新分数显示
    /// </summary>
    public void UpdateScoreText(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "分数: " + score;
        }
    }
    
    /// <summary>
    /// 显示游戏结束界面
    /// </summary>
    public void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);
    }
    
    /// <summary>
    /// 显示胜利界面
    /// </summary>
    public void ShowWinScreen(int finalScore)
    {
        winPanel.SetActive(true);
        if (finalScoreText != null)
        {
            finalScoreText.text = "最终分数: " + finalScore;
        }
    }
}
