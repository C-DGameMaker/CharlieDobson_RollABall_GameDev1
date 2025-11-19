using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    public GameObject controlsUI;

    public void Start()
    {
        controlsUI.SetActive(false);
    }
    public void OnPlayerButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void OnControlButton()
    {
        controlsUI.SetActive(true);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

}
