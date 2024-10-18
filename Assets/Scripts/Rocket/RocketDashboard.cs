using TMPro;
using UnityEngine;

public class RocketDashboard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;

    private void Update() 
    {
        float score = (transform.position.y - 0.403666f) * 1000;

        if (score < 0)
        {
            score = 0f;
        }
        currentScoreTxt.text = $"{score.ToString("N0")} M";

        if (score > GameManager.Instance.highScore)
        {
            GameManager.Instance.highScore = score;
        }
        HighScoreTxt.text = $"HIGH : {GameManager.Instance.highScore.ToString("N0")} M";
    }
        
}
