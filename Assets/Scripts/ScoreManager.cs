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
        scoreTxt.text = score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }

    public void IncreaseScore(int score)
    {
        score += score;
    }
}
