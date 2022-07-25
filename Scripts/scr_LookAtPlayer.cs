using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_LookAtPlayer : MonoBehaviour
{

    public Transform playerTarget;

    private void Awake()
    {
        playerTarget = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }

    void FixedUpdate()
    {
        if(playerTarget != null)
        {
            transform.LookAt(playerTarget);
        }
    }
}
