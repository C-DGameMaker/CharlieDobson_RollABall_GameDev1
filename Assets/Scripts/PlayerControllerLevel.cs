using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerLevel : MonoBehaviour
{
   //RigidBody of the player
    private Rigidbody rb;
    

    //Movement along the x and y axes
    private float movementX;
    private float movementY;

    //The player stats
    public float speed = 10;
    public float jumpForce = 10f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get and store the RigidBody component attached to the player
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) // Check for jump input
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply upward force
        }
    }
    private void FixedUpdate()
    {
        //Creates a 3d movement vector using the X and Y inputs
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //Apply force to the rigidbody
        rb.AddForce(movement * speed);

        

    }

    //This function is called when a move inout is detected.
    void OnMove(InputValue movementValue)
    {
        //Convert the input value into a vector2 for movement
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }



   
}
