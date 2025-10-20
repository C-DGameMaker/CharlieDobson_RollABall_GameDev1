using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public AudioSource miniGameMusic;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                PauseMenu();
            }
        }
    }
    void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        pauseMenuUI.SetActive(false);
        miniGameMusic.UnPause();
    }

    void PauseMenu()
    {
        Time.timeScale = 0f;
        isPaused = true;
        pauseMenuUI.SetActive(true);
        miniGameMusic.Pause();
    }

    public void OnResumeButton()
    {
        Resume();
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void OnQuitButton()
    {
        SceneManager.LoadScene(0);
    }

    
}
