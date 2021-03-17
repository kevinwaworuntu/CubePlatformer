using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text coinText, healthText, scoreText, timerText;
    public GameObject gameOver,finish;

    [SerializeField] PlayerManager playerManager;
    [SerializeField] GameManager gm;

    void Update()
    {      
        CoinText();
        HealthText();
        ScoreText();
        TimerText();
    }

    void CoinText()
    {
        coinText.text = "x" + playerManager.coinCollected.ToString();
    }
    void HealthText()
    {
        healthText.text = "x" + playerManager.health.ToString();
    }
    void ScoreText()
    {
        scoreText.text = "Score : " + gm.finalScore.ToString();
    }
    void TimerText()
    {
        timerText.text = "Timer : " + Mathf.RoundToInt(gm.timeRemaining).ToString();
    }

    public void _Restart()
    {
        gameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void _Menu()
    {
        finish.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
   
}
