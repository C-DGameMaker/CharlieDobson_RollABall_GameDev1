using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject controlsUI;


    public void OnBackButton()
    {
        controlsUI.SetActive(false);
    }
}
