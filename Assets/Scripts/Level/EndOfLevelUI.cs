using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevelUI : MonoBehaviour
{
    public void OnNextLevelButton()
    {
        SceneManager.LoadScene(4);
    }
}
