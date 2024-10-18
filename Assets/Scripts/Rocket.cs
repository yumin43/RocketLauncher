using UnityEditor;
using UnityEngine;
using TMPro;

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
        // TODO : Rigidbody2D ?????????? ????????(??) 
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        // TODO : fuel??? ??????????? ??? ??????? SPEED????? ???????? ??????, ??????? ??
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
}
