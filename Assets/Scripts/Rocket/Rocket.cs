using UnityEngine;
using UnityEngine.SceneManagement;
// using Microsoft.Unity.VisualStudio.Editor;

public class Rocket : MonoBehaviour
{
    public void OnRetryButtonClick()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("RocketLauncher");
    }
}
