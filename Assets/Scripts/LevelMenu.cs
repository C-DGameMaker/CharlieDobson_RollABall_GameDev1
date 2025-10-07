using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void OnMiniGameButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnLevelButton()
    {
        SceneManager.LoadScene(0);
    }

}
