using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Referes to the gameobject for the player
    public GameObject player;

    //The distance between the player and the camera
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Calcuate the offset between the camera's position and the player's position
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        //Maintains the offset between the camera and the player
        transform.position = player.transform.position + offset;
    }


}
