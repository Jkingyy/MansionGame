using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scr_DoorOpening : MonoBehaviour
{
    public GameObject C1Door1;
    public GameObject C1Door2;
    public GameObject C1Door3;
    public GameObject C1Door5;
    public GameObject C1Door6;
    public GameObject C1Door7;


    public GameObject C2Door1;
    public GameObject C2Door2;
    public GameObject C2Door3;
    public GameObject C2Door4;
    public GameObject C2Door5;
    public GameObject C2Door6;
    public GameObject C2Door7;


    public GameObject C3Door1;
    public GameObject C3Door2;
    public GameObject C3Door3;
    public GameObject C3Door4;
    public GameObject C3Door5;
    public GameObject C3Door6;
    public GameObject C3Door8;


    public GameObject C4Door1;
    public GameObject C4Door2;
    public GameObject C4Door3;
    public GameObject C4Door4;
    public GameObject C4Door5;
    public GameObject C4Door6;
    public GameObject C4Door7;
    public GameObject C4Door8;
    public GameObject C4Door9;
    public GameObject C4Door10;


    public GameObject C5Door1;
    public GameObject C5Door2;
    public GameObject C5Door3;
    public GameObject C5Door4;
    public GameObject C5Door5;
    public GameObject C5Door6;
    public GameObject C5Door7;


    public GameObject C6Door1;
    public GameObject C6Door2;
    public GameObject C6Door3;
    public GameObject C6Door4;
    public GameObject C6Door5;
    public GameObject C6Door6;
    public GameObject C6Door7;
    public GameObject C6Door8;


    public GameObject C7Door1;
    public GameObject C7Door2;
    public GameObject C7Door3;
    public GameObject C7Door4;
    public GameObject C7Door5;
    public GameObject C7Door6;
    public GameObject C7Door7;
    public GameObject C7Door8;



    public GameObject C8Door1;
    public GameObject C8Door2;
    public GameObject C8Door3;
    public GameObject C8Door4;
    public GameObject C8Door5;
    public GameObject C8Door6;
    public GameObject C8Door7;
    public GameObject C8Door8;
    public GameObject C8Door9;
    public GameObject C8Door10;



    scr_WorldInformation WorldInfo;
    Scene scene;

    public void Awake()
    {
        WorldInfo = GameObject.FindObjectOfType<scr_WorldInformation>();
    }
    public void Update()
    {
        scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (scene.name == "Corridor1")
            {
                if (other.gameObject.CompareTag("Corridor1Door1"))
                {

                    if (WorldInfo.corridor1Door1Key == true)
                    {

                        DoorOpen(C1Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor1Door2"))
                {

                    if (WorldInfo.corridor1Door2Key == true)
                    {

                        DoorOpen(C1Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor1Door3"))
                {

                    if (WorldInfo.corridor1Door3Key == true)
                    {

                        DoorOpen(C1Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor1Door5"))
                {

                    if (WorldInfo.corridor1Door5Key == true)
                    {

                        DoorOpen(C1Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor1Door6"))
                {

                    if (WorldInfo.corridor1Door6Key == true)
                    {

                        DoorOpen(C1Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor1Door7"))
                {

                    if (WorldInfo.corridor1Door7Key == true)
                    {

                        DoorOpen(C1Door7);
                    }
                }

            }








            if (scene.name == "Corridor2")
            {

                if (other.gameObject.CompareTag("Corridor2Door1"))
                {

                    if (WorldInfo.corridor2Door1Key == true)
                    {

                        DoorOpen(C2Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door2"))
                {

                    if (WorldInfo.corridor2Door2Key == true)
                    {

                        DoorOpen(C2Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door3"))
                {

                    if (WorldInfo.corridor2Door3Key == true)
                    {

                        DoorOpen(C2Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door4"))
                {

                    if (WorldInfo.corridor2Door4Key == true)
                    {

                        DoorOpen(C2Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door5"))
                {

                    if (WorldInfo.corridor2Door5Key == true)
                    {

                        DoorOpen(C2Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door6"))
                {

                    if (WorldInfo.corridor2Door6Key == true)
                    {

                        DoorOpen(C2Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor2Door7"))
                {

                    if (WorldInfo.corridor2Door7Key == true)
                    {

                        DoorOpen(C2Door7);
                    }
                }

            }








            if (scene.name == "Corridor3")
            {

                if (other.gameObject.CompareTag("Corridor3Door1"))
                {

                    if (WorldInfo.corridor3Door1Key == true)
                    {

                        DoorOpen(C3Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door2"))
                {

                    if (WorldInfo.corridor3Door2Key == true)
                    {

                        DoorOpen(C3Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door3"))
                {

                    if (WorldInfo.corridor3Door3Key == true)
                    {

                        DoorOpen(C3Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door4"))
                {

                    if (WorldInfo.corridor3Door4Key == true)
                    {

                        DoorOpen(C3Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door5"))
                {

                    if (WorldInfo.corridor3Door5Key == true)
                    {

                        DoorOpen(C3Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door6"))
                {

                    if (WorldInfo.corridor3Door6Key == true)
                    {

                        DoorOpen(C3Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor3Door8"))
                {

                    if (WorldInfo.corridor3Door8Key == true)
                    {

                        DoorOpen(C3Door8);
                    }
                }

            }








            if (scene.name == "Corridor4")
            {

                if (other.gameObject.CompareTag("Corridor4Door1"))
                {

                    if (WorldInfo.corridor4Door1Key == true)
                    {

                        DoorOpen(C4Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door2"))
                {

                    if (WorldInfo.corridor4Door2Key == true)
                    {

                        DoorOpen(C4Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door3"))
                {

                    if (WorldInfo.corridor4Door3Key == true)
                    {

                        DoorOpen(C4Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door4"))
                {

                    if (WorldInfo.corridor4Door4Key == true)
                    {

                        DoorOpen(C4Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door5"))
                {

                    if (WorldInfo.corridor4Door5Key == true)
                    {

                        DoorOpen(C4Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door6"))
                {

                    if (WorldInfo.corridor4Door6Key == true)
                    {

                        DoorOpen(C4Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door7"))
                {

                    if (WorldInfo.corridor4Door7Key == true)
                    {

                        DoorOpen(C4Door7);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door8"))
                {

                    if (WorldInfo.corridor4Door8Key == true)
                    {

                        DoorOpen(C4Door8);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door9"))
                {

                    if (WorldInfo.corridor4Door9Key == true)
                    {

                        DoorOpen(C4Door9);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor4Door10"))
                {

                    if (WorldInfo.corridor4Door10Key == true)
                    {

                        DoorOpen(C4Door10);
                    }
                }

            }









            if (scene.name == "Corridor5")
            {
                if (other.gameObject.CompareTag("Corridor5Door1"))
                {

                    if (WorldInfo.corridor5Door1Key == true)
                    {

                        DoorOpen(C5Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door2"))
                {

                    if (WorldInfo.corridor5Door2Key == true)
                    {

                        DoorOpen(C5Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door3"))
                {

                    if (WorldInfo.corridor5Door3Key == true)
                    {

                        DoorOpen(C5Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door4"))
                {

                    if (WorldInfo.corridor5Door4Key == true)
                    {

                        DoorOpen(C5Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door5"))
                {

                    if (WorldInfo.corridor5Door5Key == true)
                    {

                        DoorOpen(C5Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door6"))
                {

                    if (WorldInfo.corridor5Door6Key == true)
                    {

                        DoorOpen(C5Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor5Door7"))
                {

                    if (WorldInfo.corridor5Door7Key == true)
                    {

                        DoorOpen(C5Door7);
                    }
                }


            }








            if (scene.name == "Corridor6")
            {
                if (other.gameObject.CompareTag("Corridor6Door1"))
                {

                    if (WorldInfo.corridor6Door1Key == true)
                    {

                        DoorOpen(C6Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door2"))
                {

                    if (WorldInfo.corridor6Door2Key == true)
                    {

                        DoorOpen(C6Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door3"))
                {

                    if (WorldInfo.corridor6Door3Key == true)
                    {

                        DoorOpen(C6Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door4"))
                {

                    if (WorldInfo.corridor6Door4Key == true)
                    {

                        DoorOpen(C6Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door5"))
                {

                    if (WorldInfo.corridor7Door5Key == true)
                    {

                        DoorOpen(C6Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door6"))
                {

                    if (WorldInfo.corridor7Door6Key == true)
                    {

                        DoorOpen(C6Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door7"))
                {

                    if (WorldInfo.corridor7Door7Key == true)
                    {

                        DoorOpen(C6Door7);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor6Door8"))
                {

                    if (WorldInfo.corridor7Door8Key == true)
                    {

                        DoorOpen(C6Door8);
                    }
                }
            }










            if (scene.name == "Corridor7")
            {

                if (other.gameObject.CompareTag("Corridor7Door1"))
                {

                    if (WorldInfo.corridor7Door1Key == true)
                    {

                        DoorOpen(C7Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door2"))
                {

                    if (WorldInfo.corridor7Door2Key == true)
                    {

                        DoorOpen(C7Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door3"))
                {

                    if (WorldInfo.corridor7Door3Key == true)
                    {

                        DoorOpen(C7Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door4"))
                {

                    if (WorldInfo.corridor7Door4Key == true)
                    {

                        DoorOpen(C7Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door5"))
                {

                    if (WorldInfo.corridor7Door5Key == true)
                    {

                        DoorOpen(C7Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door6"))
                {

                    if (WorldInfo.corridor7Door6Key == true)
                    {

                        DoorOpen(C7Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door7"))
                {

                    if (WorldInfo.corridor7Door7Key == true)
                    {

                        DoorOpen(C7Door7);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor7Door8"))
                {

                    if (WorldInfo.corridor7Door8Key == true)
                    {

                        DoorOpen(C7Door8);
                    }
                }
            }











            if (scene.name == "Corridor8")
            {
                if (other.gameObject.CompareTag("Corridor8Door1"))
                {

                    if (WorldInfo.corridor8Door1Key == true)
                    {

                        DoorOpen(C8Door1);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door2"))
                {

                    if (WorldInfo.corridor8Door2Key == true)
                    {

                        DoorOpen(C8Door2);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door3"))
                {

                    if (WorldInfo.corridor8Door3Key == true)
                    {

                        DoorOpen(C8Door3);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door4"))
                {

                    if (WorldInfo.corridor8Door4Key == true)
                    {

                        DoorOpen(C8Door4);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door5"))
                {

                    if (WorldInfo.corridor8Door5Key == true)
                    {

                        DoorOpen(C8Door5);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door6"))
                {

                    if (WorldInfo.corridor8Door6Key == true)
                    {

                        DoorOpen(C8Door6);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door7"))
                {

                    if (WorldInfo.corridor8Door7Key == true)
                    {

                        DoorOpen(C8Door7);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door8"))
                {

                    if (WorldInfo.corridor8Door8Key == true)
                    {

                        DoorOpen(C8Door8);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door9"))
                {

                    if (WorldInfo.corridor8Door9Key == true)
                    {

                        DoorOpen(C8Door9);
                    }
                }
                else if (other.gameObject.CompareTag("Corridor8Door10"))
                {

                    if (WorldInfo.corridor8Door10Key == true)
                    {

                        DoorOpen(C8Door10);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Corridor1Door1Key"))
        {
            WorldInfo.corridor1Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor1Door2Key"))
        {
            WorldInfo.corridor1Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor1Door3Key"))
        {
            WorldInfo.corridor1Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor1Door5Key"))
        {
            WorldInfo.corridor1Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor1Door6Key"))
        {
            WorldInfo.corridor1Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor1Door7Key"))
        {
            WorldInfo.corridor1Door7Key = true;
            Destroy(other.gameObject);
        }






        if (other.gameObject.CompareTag("Corridor1Door1Key"))
        {
            WorldInfo.corridor2Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door2Key"))
        {
            WorldInfo.corridor2Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door3Key"))
        {
            WorldInfo.corridor2Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door4Key"))
        {
            WorldInfo.corridor2Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door5Key"))
        {
            WorldInfo.corridor2Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door6Key"))
        {
            WorldInfo.corridor2Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor2Door7Key"))
        {
            WorldInfo.corridor2Door7Key = true;
            Destroy(other.gameObject);
        }







        if (other.gameObject.CompareTag("Corridor3Door1Key"))
        {
            WorldInfo.corridor3Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door2Key"))
        {
            WorldInfo.corridor3Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door3Key"))
        {
            WorldInfo.corridor3Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door4Key"))
        {
            WorldInfo.corridor3Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door5Key"))
        {
            WorldInfo.corridor3Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door6Key"))
        {
            WorldInfo.corridor3Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor3Door8Key"))
        {
            WorldInfo.corridor3Door8Key = true;
            Destroy(other.gameObject);
        }







        if (other.gameObject.CompareTag("Corridor4Door1Key"))
        {
            WorldInfo.corridor4Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door2Key"))
        {
            WorldInfo.corridor4Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door3Key"))
        {
            WorldInfo.corridor4Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door4Key"))
        {
            WorldInfo.corridor4Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door5Key"))
        {
            WorldInfo.corridor4Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door6Key"))
        {
            WorldInfo.corridor4Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door7Key"))
        {
            WorldInfo.corridor4Door7Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door8Key"))
        {
            WorldInfo.corridor4Door8Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door9Key"))
        {
            WorldInfo.corridor4Door9Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor4Door10Key"))
        {
            WorldInfo.corridor4Door10Key = true;
            Destroy(other.gameObject);
        }






        if (other.gameObject.CompareTag("Corridor5Door1Key"))
        {
            WorldInfo.corridor5Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door2Key"))
        {
            WorldInfo.corridor5Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door3Key"))
        {
            WorldInfo.corridor5Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door4Key"))
        {
            WorldInfo.corridor5Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door5Key"))
        {
            WorldInfo.corridor5Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door6Key"))
        {
            WorldInfo.corridor5Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor5Door7Key"))
        {
            WorldInfo.corridor5Door7Key = true;
            Destroy(other.gameObject);
        }







        if (other.gameObject.CompareTag("Corridor6Door1Key"))
        {
            WorldInfo.corridor6Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door2Key"))
        {
            WorldInfo.corridor6Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door3Key"))
        {
            WorldInfo.corridor6Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door4Key"))
        {
            WorldInfo.corridor6Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door5Key"))
        {
            WorldInfo.corridor6Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door6Key"))
        {
            WorldInfo.corridor6Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door7Key"))
        {
            WorldInfo.corridor6Door7Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor6Door8Key"))
        {
            WorldInfo.corridor6Door8Key = true;
            Destroy(other.gameObject);
        }







        if (other.gameObject.CompareTag("Corridor7Door1Key"))
        {
            WorldInfo.corridor7Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door2Key"))
        {
            WorldInfo.corridor7Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door3Key"))
        {
            WorldInfo.corridor7Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door4Key"))
        {
            WorldInfo.corridor7Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door5Key"))
        {
            WorldInfo.corridor7Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door6Key"))
        {
            WorldInfo.corridor7Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door7Key"))
        {
            WorldInfo.corridor7Door7Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor7Door8Key"))
        {
            WorldInfo.corridor7Door8Key = true;
            Destroy(other.gameObject);
        }

        






        if (other.gameObject.CompareTag("Corridor8Door1Key"))
        {
            WorldInfo.corridor8Door1Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door2Key"))
        {
            WorldInfo.corridor8Door2Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door3Key"))
        {
            WorldInfo.corridor8Door3Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door4Key"))
        {
            WorldInfo.corridor8Door4Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door5Key"))
        {
            WorldInfo.corridor8Door5Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door6Key"))
        {
            WorldInfo.corridor8Door6Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door7Key"))
        {
            WorldInfo.corridor8Door7Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door8Key"))
        {
            WorldInfo.corridor8Door8Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door9Key"))
        {
            WorldInfo.corridor8Door9Key = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Corridor8Door10Key"))
        {
            WorldInfo.corridor8Door10Key = true;
            Destroy(other.gameObject);
        }
    }



    public void DoorOpen(GameObject door)
    {
        door.transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}
