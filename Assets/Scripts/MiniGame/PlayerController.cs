using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //Rigidbody of the player
    private Rigidbody rb;

    private int count;
    private float startTimer = 60;
    private float curTimer;

    //Movement along the x and y axes
    private float movementX;
    private float movementY;

    //The player speed
    public float speed = 10;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI timerText;

    public GameObject winTextObject;

    public AudioSource SoundEffects;
    public AudioClip pickUp;
    public AudioClip death;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get and store the RigidBody component attached to the player
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();

        curTimer = startTimer;
       
        winTextObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        //Creates a 3d movement vector using the X and Y inputs
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        //Apply force to the rigidbody
        rb.AddForce(movement * speed);

        if(curTimer > 0 && count < 10)
        {
            curTimer -= Time.deltaTime;
            SetTimerText();
        }
        else if(count >= 10)
        {
            curTimer = startTimer;
        }
        else
        {
            curTimer = 0;
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            SoundEffects.clip = death;
            SoundEffects.Play();
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            SoundEffects.clip = pickUp;
            SoundEffects.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            SoundEffects.clip = death;
            SoundEffects.Play();
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

    void SetTimerText()
    {
        int intTime = (int)curTimer;
        string time = Convert.ToString(intTime);
        timerText.text = "Timer: " + time;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 10)
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            winTextObject.SetActive(true);
        }
           

    }
}
