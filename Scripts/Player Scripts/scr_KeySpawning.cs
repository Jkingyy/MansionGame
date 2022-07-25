using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_KeySpawning : MonoBehaviour
{

    scr_WorldInformation WorldInfo;

    Scene scene;


    public GameObject C1D1KeyPrefab;
    public GameObject C1D2KeyPrefab;
    public GameObject C1D3KeyPrefab;
    public GameObject C1D5KeyPrefab;
    public GameObject C1D6KeyPrefab;
    public GameObject C1D7KeyPrefab;


    public GameObject C2D1KeyPrefab;
    public GameObject C2D2KeyPrefab;
    public GameObject C2D3KeyPrefab;
    public GameObject C2D4KeyPrefab;
    public GameObject C2D5KeyPrefab;
    public GameObject C2D6KeyPrefab;
    public GameObject C2D7KeyPrefab;


    public GameObject C3D1KeyPrefab;
    public GameObject C3D2KeyPrefab;
    public GameObject C3D3KeyPrefab;
    public GameObject C3D4KeyPrefab;
    public GameObject C3D5KeyPrefab;
    public GameObject C3D6KeyPrefab;
    public GameObject C3D8KeyPrefab;


    public GameObject C4D1KeyPrefab;
    public GameObject C4D2KeyPrefab;
    public GameObject C4D3KeyPrefab;
    public GameObject C4D4KeyPrefab;
    public GameObject C4D5KeyPrefab;
    public GameObject C4D6KeyPrefab;
    public GameObject C4D7KeyPrefab;
    public GameObject C4D8KeyPrefab;
    public GameObject C4D9KeyPrefab;
    public GameObject C4D10KeyPrefab;


    public GameObject C5D1KeyPrefab;
    public GameObject C5D2KeyPrefab;
    public GameObject C5D3KeyPrefab;
    public GameObject C5D4KeyPrefab;
    public GameObject C5D5KeyPrefab;
    public GameObject C5D6KeyPrefab;
    public GameObject C5D7KeyPrefab;



    public GameObject C6D1KeyPrefab;
    public GameObject C6D2KeyPrefab;
    public GameObject C6D3KeyPrefab;
    public GameObject C6D4KeyPrefab;
    public GameObject C6D5KeyPrefab;
    public GameObject C6D6KeyPrefab;
    public GameObject C6D7KeyPrefab;
    public GameObject C6D8KeyPrefab;



    public GameObject C7D1KeyPrefab;
    public GameObject C7D2KeyPrefab;
    public GameObject C7D3KeyPrefab;
    public GameObject C7D4KeyPrefab;
    public GameObject C7D5KeyPrefab;
    public GameObject C7D6KeyPrefab;
    public GameObject C7D7KeyPrefab;
    public GameObject C7D8KeyPrefab;



    public GameObject C8D1KeyPrefab;
    public GameObject C8D2KeyPrefab;
    public GameObject C8D3KeyPrefab;
    public GameObject C8D4KeyPrefab;
    public GameObject C8D5KeyPrefab;
    public GameObject C8D6KeyPrefab;
    public GameObject C8D7KeyPrefab;
    public GameObject C8D8KeyPrefab;
    public GameObject C8D9KeyPrefab;
    public GameObject C8D10KeyPrefab;

    public GameObject FrontDoorKeyPrefab;

    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
        WorldInfo = GameObject.FindObjectOfType<scr_WorldInformation>();


        if(scene.name == "Corridor1")
        {
            if(WorldInfo.corridor5Door5Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C5D5KeyPrefab);
            }
            if (WorldInfo.corridor1Door3Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C1D3KeyPrefab);
            }
            if (WorldInfo.corridor6Door7Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C6D7KeyPrefab);
            }
            if (WorldInfo.corridor1Door1Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C1D1KeyPrefab);
            }
            if (WorldInfo.corridor3Door6Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C3D6KeyPrefab);
            }
            if (WorldInfo.corridor1Door5Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C1D5KeyPrefab);
            }
            if (WorldInfo.corridor6Door2Key == false)
            {
                SpawnKey(14f, 1.5f, 17f, C6D2KeyPrefab);
            }

        }
        else if (scene.name == "Corridor2")
        {
            if (WorldInfo.corridor6Door8Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C6D8KeyPrefab);
            }
            if (WorldInfo.corridor2Door5Key == false)
            {
                SpawnKey(-32f, 1.5f, -14.5f, C2D5KeyPrefab);
            }
            if (WorldInfo.corridor7Door4Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C7D4KeyPrefab);
            }
            if (WorldInfo.corridor3Door4Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C3D4KeyPrefab);
            }
            if (WorldInfo.corridor3Door8Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C3D8KeyPrefab);
            }
            if (WorldInfo.corridor2Door3Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C2D3KeyPrefab);
            }
            if (WorldInfo.corridor2Door1Key == false)
            {
                SpawnKey(14f, 1.5f, 17f, C2D1KeyPrefab);
            }
        }
        else if (scene.name == "Corridor3")
        {
            if (WorldInfo.corridor2Door6Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C2D6KeyPrefab);
            }
            if (WorldInfo.corridor6Door6Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C6D6KeyPrefab);
            }
            if (WorldInfo.corridor3Door5Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C3D5KeyPrefab);
            }
            if (WorldInfo.corridor1Door6Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C1D6KeyPrefab);
            }
            if (WorldInfo.corridor1Door2Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C1D2KeyPrefab);
            }
            if (WorldInfo.corridor3Door1Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C3D1KeyPrefab);
            }
            if (WorldInfo.corridor4Door7Key == false)
            {
                SpawnKey(43.5f, 1.5f, 12f, C4D7KeyPrefab);
            }
        }
        else if (scene.name == "Corridor4")
        {
            if (WorldInfo.corridor4Door9Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C4D9KeyPrefab);
            }
            if (WorldInfo.corridor7Door5Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C7D5KeyPrefab);
            }
            if (WorldInfo.corridor5Door4Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C5D4KeyPrefab);
            }
            if (WorldInfo.corridor5Door2Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C5D2KeyPrefab);
            }
            if (WorldInfo.corridor8Door7Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C8D7KeyPrefab);
            }
            if (WorldInfo.corridor4Door3Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C4D3KeyPrefab);
            }
            if (WorldInfo.corridor4Door10Key == false)
            {
                SpawnKey(69f, 1.5f, 22.5f, C4D10KeyPrefab);
            }
            if (WorldInfo.corridor4Door6Key == false)
            {
                SpawnKey(43.5f, 1.5f, 12f, C4D6KeyPrefab);
            }
            if (WorldInfo.corridor4Door4Key == false)
            {
                SpawnKey(-16.5f, 1.5f, 33f, C4D4KeyPrefab);
            }
            if (WorldInfo.corridor4Door1Key == false)
            {
                SpawnKey(-42.5f, 1.5f, 22.5f, C4D1KeyPrefab);
            }
        }
        else if (scene.name == "Corridor5")
        {
            if (WorldInfo.corridor5Door7Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C5D7KeyPrefab);
            }
            if (WorldInfo.corridor5Door6Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C5D6KeyPrefab);
            }
            if (WorldInfo.corridor6Door4Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C6D4KeyPrefab);
            }
            if (WorldInfo.corridor6Door1Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C6D1KeyPrefab);
            }
            if (WorldInfo.corridor4Door5Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C4D5KeyPrefab);
            }
            if (WorldInfo.corridor7Door1Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C7D1KeyPrefab);
            }
            if (WorldInfo.corridor3Door3Key == false)
            {
                SpawnKey(14f, 1.5f, -46f, C3D3KeyPrefab);
            }
        }
        else if (scene.name == "Corridor6")
        {
            if (WorldInfo.corridor7Door2Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C7D2KeyPrefab);
            }
            if (WorldInfo.corridor2Door7Key == false)
            {
                SpawnKey(-32f, 1.5f, -14.5f, C2D7KeyPrefab);
            }
            if (WorldInfo.corridor4Door8Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C4D8KeyPrefab);
            }
            if (WorldInfo.corridor8Door8Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C8D8KeyPrefab);
            }
            if (WorldInfo.corridor8Door9Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C8D9KeyPrefab);
            }
            if (WorldInfo.corridor8Door5Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C8D5KeyPrefab);
            }
            if (WorldInfo.corridor8Door10Key == false)
            {
                SpawnKey(14f, 1.5f, -46f, C8D10KeyPrefab);
            }
            if (WorldInfo.corridor6Door5Key == false)
            {
                SpawnKey(-15.5f, 1.5f, -4f, C6D5KeyPrefab);
            }
        }
        else if (scene.name == "Corridor7")
        {
            if (WorldInfo.corridor7Door8Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C7D8KeyPrefab);
            }
            if (WorldInfo.corridor8Door2Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C8D2KeyPrefab);
            }
            if (WorldInfo.corridor5Door1Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C5D1KeyPrefab);
            }
            if (WorldInfo.corridor7Door3Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C7D3KeyPrefab);
            }
            if (WorldInfo.corridor5Door3Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, C5D3KeyPrefab);
            }
            if (WorldInfo.corridor1Door7Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C1D7KeyPrefab);
            }
            if (WorldInfo.corridor6Door3Key == false)
            {
                SpawnKey(-41f, 1.5f, -51.5f, C6D3KeyPrefab);
            }
            if (WorldInfo.corridor7Door6Key == false)
            {
                SpawnKey(-15.5f, 1.5f, -41f, C7D6KeyPrefab);
            }
        }
        else if (scene.name == "Corridor8")
        {
            if (WorldInfo.corridor8Door3Key == false)
            {
                SpawnKey(3.5f, 1.5f, 0.5f, C8D3KeyPrefab);
            }
            if (WorldInfo.corridor2Door4Key == false)
            {
                SpawnKey(3.5f, 1.5f, -14.5f, C2D4KeyPrefab);
            }
            if (WorldInfo.corridor2Door2Key == false)
            {
                SpawnKey(3.5f, 1.5f, -29.5f, C2D2KeyPrefab);
            }
            if (WorldInfo.corridor8Door1Key == false)
            {
                SpawnKey(24.5f, 1.5f, -29.5f, C8D1KeyPrefab);
            }
            if (WorldInfo.corridor8Door7Key == false)
            {
                SpawnKey(24.5f, 1.5f, -14.5f, FrontDoorKeyPrefab);
            }
            if (WorldInfo.corridor7Door7Key == false)
            {
                SpawnKey(24.5f, 1.5f, 0.5f, C7D7KeyPrefab);
            }
            if (WorldInfo.corridor4Door2Key == false)
            {
                SpawnKey(-41f, 1.5f, -51.5f, C4D2KeyPrefab);
            }
            if (WorldInfo.corridor8Door6Key == false)
            {
                SpawnKey(-15.5f, 1.5f, -41f, C8D6KeyPrefab);
            }
            if (WorldInfo.corridor3Door2Key == false)
            {
                SpawnKey(44.5f, 1.5f, -62f, C3D2KeyPrefab);
            }
            if (WorldInfo.corridor8Door4Key == false)
            {
                SpawnKey(70.5f, 1.5f, -51.5f, C4D1KeyPrefab);
            }
        }

    }


    private void SpawnKey(float pX, float pY, float pZ, GameObject pKeyPrefab)
    {
        Instantiate(pKeyPrefab, new Vector3(pX, pY, pZ), Quaternion.identity);
    }

}
