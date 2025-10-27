using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartKey : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;
        }
    }
}
