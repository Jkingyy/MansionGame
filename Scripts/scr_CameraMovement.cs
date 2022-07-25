
using UnityEngine;

public class scr_CameraMovement : MonoBehaviour
{

    public Transform playerTarget;
    public Transform room1Target;
    public Transform room2Target;
    public Transform room3Target;
    public Transform room4Target;
    public Transform room5Target;
    public Transform room6Target;
    public Transform room7Target;
    public Transform room8Target;
    public Transform room9Target;
    public Transform room10Target;

    public float smoothSpeed = 10f;
    public Vector3 followingOffset;

    public Vector3 staticOffset;

    public bool inRoom = true;

    public float opacity = 0.3f;
    public GameObject Room1wallR;
    public GameObject Room1wallL;
    public GameObject Room1DoorFrame;

    public GameObject Room2wallR;
    public GameObject Room2wallL;
    public GameObject Room2DoorFrame;
    public GameObject Room2wallR2;
    public GameObject Room2wallL2;
    public GameObject Room2CorridorwallR;
    public GameObject Room2CorridorwallL;

    public GameObject Room3wallR;
    public GameObject Room3wallL;
    public GameObject Room3DoorFrame;
    public GameObject Room3Door;

    public GameObject Room4wall;
    public GameObject Room5wall;
    public GameObject Room6wall;

    public GameObject Room7wall;

    public GameObject Room7wallR;
    public GameObject Room7wallL;
    public GameObject Room7DoorFrame;
    public GameObject Room7wallR2;
    public GameObject Room7wallL2;
    public GameObject Room7CorridorwallR;
    public GameObject Room7CorridorwallL;

    public GameObject Room8wall;
    public GameObject Room9wall;


    public GameObject Room10wall;

    public GameObject Room10wallR;
    public GameObject Room10wallL;
    public GameObject Room10DoorFrame;
    public GameObject Room10wallR2;
    public GameObject Room10wallL2;
    public GameObject Room10CorridorwallR;
    public GameObject Room10CorridorwallL;

    public string currentRoom;

    scr_ChangeScene Scene;

    private void Awake()
    {
        Scene = GameObject.FindObjectOfType<scr_ChangeScene>();
    }

    private void LateUpdate()
    {
        if (inRoom == false)
        {
            if (currentRoom == "room1")
            {
                Vector3 desiredPosition = room1Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room1Target);
            }
            else if(currentRoom == "room2")
            {
                Vector3 desiredPosition = room2Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room2Target);
            }
            else if (currentRoom == "room3")
            {
                Vector3 desiredPosition = room3Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room3Target);
            }
            else if (currentRoom == "room4")
            {
                Vector3 desiredPosition = room4Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room4Target);
            }
            else if (currentRoom == "room5")
            {
                Vector3 desiredPosition = room5Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room5Target);
            }
            else if (currentRoom == "room6")
            {
                Vector3 desiredPosition = room6Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room6Target);
            }
            else if (currentRoom == "room7")
            {
                Vector3 desiredPosition = room7Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room7Target);
            }
            else if (currentRoom == "room8")
            {
                Vector3 desiredPosition = room8Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room8Target);
            }
            else if (currentRoom == "room9")
            {
                Vector3 desiredPosition = room9Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room9Target);
            }
            else if (currentRoom == "room10")
            {
                Vector3 desiredPosition = room10Target.position + staticOffset;
                Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
                transform.position = desiredPosition;

                transform.LookAt(room10Target);
            }
        }
        else
        {
            Vector3 desiredPosition = playerTarget.position + followingOffset;
            Vector3 smoothedPostion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = desiredPosition;

            transform.LookAt(playerTarget);
        }

    }

    public bool RoomChange(string pCurrentRoom)
    {
        currentRoom = pCurrentRoom;
        if (currentRoom == "room1")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room1wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room1wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room1DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
            else
            {
                inRoom = false;

                Room1wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room1wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room1DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
        else if (currentRoom == "room2")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room2wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room2wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room2DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if(Scene.scene.name == "Corridor2" || Scene.scene.name == "Corridor6")
                {
                    Room2wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room2wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room2CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room2CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                }

            }
            else
            {
                inRoom = false;

                Room2wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room2wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room2DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                if (Scene.scene.name == "Corridor2" || Scene.scene.name == "Corridor6")
                {
                    Room2wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room2wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room2CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room2CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
            }
        }

        if (currentRoom == "room3")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room3wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room3wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room3DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                Room3Door.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
            else
            {
                inRoom = false;

                Room3wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room3wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room3DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                Room3Door.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }

        if (currentRoom == "room4")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room4wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
            else
            {
                inRoom = false;

                Room4wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            }
        }

        if (currentRoom == "room5")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room5wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
            else
            {
                inRoom = false;

                Room5wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            }
        }

        if (currentRoom == "room6")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room6wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
            else
            {
                inRoom = false;

                Room6wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            }
        }

        if (currentRoom == "room7")
        {

            if (inRoom == false)
            {
                inRoom = true;

                if (Scene.scene.name == "Corridor7" || Scene.scene.name == "Corridor8")
                {
                    Room7wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room7DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                }
                else
                {
                    Room7wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                }

            }
            else
            {
                inRoom = false;


                if (Scene.scene.name == "Corridor7" || Scene.scene.name == "Corridor8")
                {
                    Room7wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room7DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                }
                else
                {
                    Room7wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
            }
        }

        if (currentRoom == "room8")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room8wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
            else
            {
                inRoom = false;

                Room8wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            }
        }


        if (currentRoom == "room9")
        {

            if (inRoom == false)
            {
                inRoom = true;
                Room9wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
            else
            {
                inRoom = false;

                Room9wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

            }
        }

        else if (currentRoom == "room10")
        {

            if (inRoom == false)
            {
                inRoom = true;

                if (Scene.scene.name == "Corridor8")
                {
                    Room10wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                }
                else
                {
                    Room10wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room10wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room10DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

                    Room10wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room10wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room10CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                    Room10CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                }


            }
            else
            {
                inRoom = false;


                if (Scene.scene.name == "Corridor8")
                {
                    Room10wall.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }
                else
                {
                    Room10wallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room10wallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room10DoorFrame.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;

                    Room10wallL2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room10wallR2.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room10CorridorwallL.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                    Room10CorridorwallR.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                }

            }
        }

        return inRoom;
    }
}
