using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void OnMiniGameButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnLevelButton()
    {
        SceneManager.LoadScene(3);
    }

}
