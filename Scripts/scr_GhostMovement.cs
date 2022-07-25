using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_GhostMovement : MonoBehaviour
{
    public float moveSpeed;
    public float moveSpeedMultiplier;
    public Rigidbody rb;

    public GameObject player;
    private Rigidbody playerRb;

    public scr_WorldInformation worldInformtaion;

    // Start is called before the first frame update
    void Start()
    {
        worldInformtaion = GameObject.FindObjectOfType<scr_WorldInformation>();

        player = GameObject.FindGameObjectsWithTag("Player")[0];
        playerRb = player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {



        Vector3 aimDir = playerRb.position - rb.position;
        float playerDistance = Mathf.Sqrt((aimDir.x * aimDir.x) + (aimDir.z * aimDir.z));
        if(playerDistance < 10)
        {
            moveSpeed = moveSpeed * moveSpeedMultiplier;
        }
        float step = moveSpeed * Time.deltaTime;
        rb.position = Vector3.MoveTowards(rb.position, playerRb.position, step);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            worldInformtaion.corridor1KickedOut = true;
            worldInformtaion.corridor2KickedOut = true;
            worldInformtaion.corridor3KickedOut = true;
            worldInformtaion.corridor4KickedOut = true;
            worldInformtaion.corridor5KickedOut = true;
            worldInformtaion.corridor6KickedOut = true;
            worldInformtaion.corridor7KickedOut = true;
            worldInformtaion.corridor8KickedOut = true;
        }
    }
}
