using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Rigidbody of the player
    private Rigidbody rb;

    private int count;

    //Movement along the x and y axes
    private float movementX;
    private float movementY;

    //The player speed
    public float speed = 10;
    public TextMeshProUGUI countText;

    public GameObject winTextObject;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get and store the RigidBody component attached to the player
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();

        winTextObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        //Creates a 3d movement vector using the X and Y inputs
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //Apply force to the rigidbody
        rb.AddForce(movement * speed);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    //This function is called when a move inout is detected.
    void OnMove(InputValue movementValue)
    {
        //Convert the input value into a vector2 for movement
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 10)
        {
            winTextObject.SetActive(true);
        }
           

    }
}
