using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float highScore = 0f;

    private void Awake() 
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
}
