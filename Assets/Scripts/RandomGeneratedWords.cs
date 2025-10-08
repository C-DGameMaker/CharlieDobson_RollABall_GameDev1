using TMPro;
using UnityEngine;

public class RandomGeneratedWords : MonoBehaviour
{
    public GameObject splashText;
    void Start()
    { 
        string[] words = { "Better than Grandma", "As seen on Tv", "LESS POLYGONS!", "Dynamic Lighting", "Created to spread evil", "Yo Mama", "YOLO", "It's a game" };

        int wordChoice = Random.Range(0, words.Length);

        splashText.GetComponent<TextMeshProUGUI>().text = words[wordChoice]; ;
    }

}
