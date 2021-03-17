using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerManager playerManager;
    private AudioManager audioManager;
    private UIManager ui;
    public int finalScore;
    public bool isGameOver,isFinish;

    [SerializeField] float startTime;
    public float timeRemaining;


    void Start()
    {
        Time.timeScale = 1;
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();
        audioManager = GameObject.FindGameObjectWithTag("Game Manager").GetComponent<AudioManager>();
        ui = GameObject.FindGameObjectWithTag("UI Manager").GetComponent<UIManager>();
        timeRemaining = startTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            Timer();
            Score();

            //If Player Finish the Game
            if (!isGameOver && isFinish)
            {
                Finish();
            }
            else
            {
                if (playerManager.health <= 0)
                {
                    GameOver();
                }
            }
            
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        audioManager.UISFX();
        ui.gameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void Finish()
    {
        ui.finish.SetActive(true);
        Time.timeScale = 0;
    }
    private void Timer()
    {
        timeRemaining -= Time.deltaTime;
    }

    private int Score()
    {
        finalScore = Mathf.RoundToInt(timeRemaining) * playerManager.coinCollected;
        return finalScore;
    }
}
