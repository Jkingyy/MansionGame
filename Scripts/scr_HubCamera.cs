using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_HubCamera : MonoBehaviour
{
    public Text AllowedentryText1;
    public Text AllowedentryText2;
    public Text AllowedentryText3;
    public Text AllowedentryText4;
    public Text AllowedentryText5;
    public Text AllowedentryText6;
    public Text AllowedentryText7;
    public Text AllowedentryText8;

    scr_WorldInformation allowedToEnter;


    public Transform playerTarget;


    public Transform BackLeftTarget;
    public Transform BackRightTarget;


    private string currentCamera = "player";



    public GameObject upstairs1;
    public GameObject upstairs2;
    public GameObject upstairs3;
    public GameObject upstairs4;
    public GameObject upstairs5;
    public GameObject upstairs6;
    public GameObject upstairs7;
    public GameObject upstairs8;
    public GameObject upstairs9;
    public GameObject upstairs10;
    public GameObject upstairs11;
    public GameObject upstairs12;
    public GameObject upstairs13;
    public GameObject upstairs14;
    public GameObject upstairs15;
    public GameObject upstairs16;
    public GameObject upstairs17;
    public GameObject upstairs18;

    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    public GameObject Door4;

    public GameObject DownstairsLeftWall;
    public GameObject DownstairsRightWall;
    public GameObject DownstairsTopWall;
    public GameObject DownstairsDoorFrame;

    public float smoothSpeed = 10f;
    public Vector3 followingOffset;

    public Vector3 staticOffset;

    private bool isDownstairs = true;

    private void Awake()
    {
        allowedToEnter = GameObject.FindObjectOfType<scr_WorldInformation>();
        AllowedentryText1 = GameObject.Find("AllowedText1").GetComponent<Text>();
        AllowedentryText2 = GameObject.Find("AllowedText2").GetComponent<Text>();
        AllowedentryText3 = GameObject.Find("AllowedText3").GetComponent<Text>();
        AllowedentryText4 = GameObject.Find("AllowedText4").GetComponent<Text>();
        AllowedentryText5 = GameObject.Find("AllowedText5").GetComponent<Text>();
        AllowedentryText6 = GameObject.Find("AllowedText6").GetComponent<Text>();
        AllowedentryText7 = GameObject.Find("AllowedText7").GetComponent<Text>();
        AllowedentryText8 = GameObject.Find("AllowedText8").GetComponent<Text>();

        allowedToEnter.inCorridor1 = false;
        allowedToEnter.inCorridor2 = false;
        allowedToEnter.inCorridor3 = false;
        allowedToEnter.inCorridor4 = false;
        allowedToEnter.inCorridor5 = false;
        allowedToEnter.inCorridor6 = false;
        allowedToEnter.inCorridor7 = false;
        allowedToEnter.inCorridor8 = false;


        upstairs1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs5.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs6.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs7.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs8.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs9.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs10.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs11.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs12.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs13.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs14.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs15.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs16.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs17.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        upstairs18.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

        Door1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        Door2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        Door3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        Door4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

        DownstairsLeftWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        DownstairsRightWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        DownstairsTopWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        DownstairsDoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }

    private void Update()
    {
        if(allowedToEnter.corridor1AllowedEntry == true)
        {
            AllowedentryText1.text = "Corridor 1 is Open";
        }
        else
        {
            AllowedentryText1.text = "Corridor 1 is Closed";
        }

        if (allowedToEnter.corridor2AllowedEntry == true)
        {
            AllowedentryText2.text = "Corridor 2 is Open";
        }
        else
        {
            AllowedentryText2.text = "Corridor 2 is Closed";
        }

        if (allowedToEnter.corridor3AllowedEntry == true)
        {
            AllowedentryText3.text = "Corridor 3 is Open";
        }
        else
        {
            AllowedentryText3.text = "Corridor 3 is Closed";
        }

        if (allowedToEnter.corridor4AllowedEntry == true)
        {
            AllowedentryText4.text = "Corridor 4 is Open";
        }
        else
        {
            AllowedentryText4.text = "Corridor 4 is Closed";
        }

        if (allowedToEnter.corridor5AllowedEntry == true)
        {
            AllowedentryText5.text = "Corridor 5 is Open";
        }
        else
        {
            AllowedentryText5.text = "Corridor 5 is Closed";
        }

        if (allowedToEnter.corridor6AllowedEntry == true)
        {
            AllowedentryText6.text = "Corridor 6 is Open";
        }
        else
        {
            AllowedentryText6.text = "Corridor 6 is Closed";
        }

        if (allowedToEnter.corridor7AllowedEntry == true)
        {
            AllowedentryText7.text = "Corridor 7 is Open";
        }
        else
        {
            AllowedentryText7.text = "Corridor 7 is Closed";
        }

        if (allowedToEnter.corridor8AllowedEntry == true)
        {
            AllowedentryText8.text = "Corridor 8 is Open";
        }
        else
        {
            AllowedentryText8.text = "Corridor 8 is Closed";
        }
    }


    private void LateUpdate()
    {

        if (currentCamera == "backleft")
        {
            Vector3 desiredPosition = BackLeftTarget.position + staticOffset;
            Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = desiredPosition;

            transform.LookAt(BackLeftTarget);
        }
        else if (currentCamera == "backright")
        {
            Vector3 desiredPosition = BackRightTarget.position + staticOffset;
            Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = desiredPosition;

            transform.LookAt(BackRightTarget);
        }
        else if (currentCamera == "player")
        {
            Vector3 desiredPosition = playerTarget.position + followingOffset;
            Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = desiredPosition;

            transform.LookAt(playerTarget);
        }


    }

    public bool FloorChange()
    {
        if (isDownstairs == false)
        {
            isDownstairs = true;

            upstairs1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs5.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs6.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs8.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs9.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs10.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs11.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs12.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs13.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs14.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs15.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs16.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs17.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            upstairs18.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            Door1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            Door2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            Door3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            Door4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

        }
        else
        {
            isDownstairs = false;

            upstairs1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs5.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs6.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs8.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs9.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs10.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs11.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs12.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs13.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs14.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs15.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs16.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs17.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            upstairs18.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            Door1.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            Door2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            Door3.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            Door4.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

        }
        if (currentCamera == "player")
        {
            DownstairsLeftWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            DownstairsRightWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            DownstairsTopWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            DownstairsDoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        }
        else if( currentCamera != "player")
        {
            DownstairsLeftWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            DownstairsRightWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            DownstairsTopWall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            DownstairsDoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }


        return isDownstairs;
    }

    public void CameraChange(string pCurrentCamera)
    {
        currentCamera = pCurrentCamera;

    }
}
