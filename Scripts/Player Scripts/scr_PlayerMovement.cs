using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float walkingSpeed;
    public float sprintingSpeed;

    bool isGrounded;
    public float fallSpeed;

    public Rigidbody rb;
    bool inRoom = true;

    bool isDownstairs = true;

    Vector3 input;

    public scr_CameraMovement cameraMovement;
    public scr_HubCamera cameraHubMovement;

    void Awake()
    {

        cameraMovement = GameObject.FindObjectOfType<scr_CameraMovement>();
        cameraHubMovement = GameObject.FindObjectOfType<scr_HubCamera>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Z))
        {
            moveSpeed = sprintingSpeed;
        }
        else
        {
            moveSpeed = walkingSpeed;
        }


    }


    void FixedUpdate()
    {

        rb.velocity = new Vector3(-(input.y * moveSpeed), 0  , (input.x * moveSpeed));

        if(isGrounded == false)
        {
            rb.velocity = new Vector3(-(input.y * moveSpeed),  -fallSpeed, (input.x * moveSpeed));
        }
        else
        {
            rb.velocity = new Vector3(-(input.y * moveSpeed), 0, (input.x * moveSpeed));
        }

    }

    public void OnTriggerEnter(Collider other)
    {


        //Corridor


        if (other.gameObject.CompareTag("Room1Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room1");
            }
        }
        if (other.gameObject.CompareTag("Room1Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room1");
            }
        }

        if (other.gameObject.CompareTag("Room2Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room2");
            }
        }
        if (other.gameObject.CompareTag("Room2Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room2");
            }
        }

        if (other.gameObject.CompareTag("Room3Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room3");
            }
        }
        if (other.gameObject.CompareTag("Room3Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room3");
            }
        }

        if (other.gameObject.CompareTag("Room4Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room4");
            }
        }
        if (other.gameObject.CompareTag("Room4Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room4");
            }
        }

        if (other.gameObject.CompareTag("Room5Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room5");
            }
        }
        if (other.gameObject.CompareTag("Room5Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room5");
            }
        }

        if (other.gameObject.CompareTag("Room6Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room6");
            }
        }
        if (other.gameObject.CompareTag("Room6Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room6");
            }
        }

        if (other.gameObject.CompareTag("Room7Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room7");
            }
        }
        if (other.gameObject.CompareTag("Room7Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room7");
            }
        }

        if (other.gameObject.CompareTag("Room8Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room8");
            }
        }
        if (other.gameObject.CompareTag("Room8Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room8");
            }
        }

        if (other.gameObject.CompareTag("Room9Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room9");
            }
        }
        if (other.gameObject.CompareTag("Room9Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room9");
            }
        }
        if (other.gameObject.CompareTag("Room10Entry"))
        {
            if (inRoom == true)
            {
                inRoom = cameraMovement.RoomChange("room10");
            }
        }
        if (other.gameObject.CompareTag("Room10Exit"))
        {
            if (inRoom == false)
            {
                inRoom = cameraMovement.RoomChange("room10");
            }
        }






        //Hub World

        if (other.gameObject.CompareTag("UpstairsEntry"))
        {
            if (isDownstairs == true)
            {
                isDownstairs = cameraHubMovement.FloorChange();
            }
        }
        if (other.gameObject.CompareTag("UpstairsExit"))
        {
            if (isDownstairs == false)
            {
                isDownstairs = cameraHubMovement.FloorChange();
            }
        }


        if (other.gameObject.CompareTag("BackLeft"))
        {
            cameraHubMovement.CameraChange("backleft");
        }
        if (other.gameObject.CompareTag("BackRight"))
        {
            cameraHubMovement.CameraChange("backright");
        }
        if (other.gameObject.CompareTag("PlayerTrigger"))
        {
            cameraHubMovement.CameraChange("player");
        }




    }




}



