using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public int targetScore = 60;
    public GameObject victoryPanel;
    public TMP_Text scoreText;


    private void Update()
    {


        if (score >= targetScore)
        {
            TriggerVictory();
        }

        scoreText.text = "Score: " + score.ToString();
    }
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;

        if (score >= targetScore)
        {
            TriggerVictory();
        }
    }

    void TriggerVictory()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
        }
    }
}