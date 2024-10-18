using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : MonoBehaviour
{
    private float fuel = 100f;
    [SerializeField] private Image hpImage;

    private Rigidbody2D _rb2d;

    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    
    private void Update() 
    {
        fuel += 10f * Time.deltaTime;

        if (fuel >= 100f)
        {
            fuel = 100f;
        }

        hpImage.fillAmount = fuel * 0.01f;
    }    

    public void Shoot()
    {
        if (fuel >= FUELPERSHOOT)
        {
            fuel -= FUELPERSHOOT;
            hpImage.fillAmount = fuel * 0.01f;
            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
        }
        else
        {
            return;
        }
    }
}
