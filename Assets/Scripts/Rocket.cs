using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;
    
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        if (fuel >= 10f)
        {
            fuel -= 10f;
            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
        }
        else
        {
            return;
        }
    }

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

    public void OnRetryButtonClick()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("RocketLauncher");
    }
}
