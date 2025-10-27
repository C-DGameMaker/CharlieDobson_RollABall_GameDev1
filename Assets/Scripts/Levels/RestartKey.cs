using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartKey : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
        }
    }
}
