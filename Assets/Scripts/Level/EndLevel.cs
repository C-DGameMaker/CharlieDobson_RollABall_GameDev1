using UnityEngine;
using UnityEngine.Playables;

public class EndLevel : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject win;

    private void Start()
    {
        win.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            win.SetActive(true);
            timeline.Play();
        }
    }
}
