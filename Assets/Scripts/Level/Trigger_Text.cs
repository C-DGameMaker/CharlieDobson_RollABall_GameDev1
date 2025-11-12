using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger_Text : MonoBehaviour
{
    public GameObject tutorialTextObject;
    public TextMeshProUGUI tutorialJumpText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tutorialTextObject.SetActive(true);
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        tutorialTextObject.GetComponent<TextMeshProUGUI>().text = "You can jump with the spacebar.";
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tutorialTextObject.SetActive(false);
        }
    }

    
}
