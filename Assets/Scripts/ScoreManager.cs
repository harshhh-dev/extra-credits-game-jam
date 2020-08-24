using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    [SerializeField] TextMeshProUGUI scoreTxt;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreTxt.text = score + " / 120".ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }

    public void IncreaseScore(int score)
    {
        score += score;
    }
}
