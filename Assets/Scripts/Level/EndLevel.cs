using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public Animator flag;
    public GameObject win;

    private void Start()
    {
        win.SetActive(false);
        flag.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            win.SetActive(true);
            flag.enabled = true;
            flag.SetTrigger("flagUp");
        }
    }
}
