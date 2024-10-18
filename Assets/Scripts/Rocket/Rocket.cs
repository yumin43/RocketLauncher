using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public void OnRetryButtonClick()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("RocketLauncher");
    }
}
