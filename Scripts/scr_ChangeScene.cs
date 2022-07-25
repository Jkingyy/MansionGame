using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class scr_ChangeScene : MonoBehaviour
{
    Scene scene;
    scr_WorldInformation WorldInfo;

    public GameObject ghostPrefab;

    public Text timerText;
    public Text AllowedentryText;

    private void Awake()
    {
        WorldInfo = GameObject.FindObjectOfType<scr_WorldInformation>();
        scene = SceneManager.GetActiveScene();


        if(scene.name == "Corridor1")
        {
            WorldInfo.timerPause = false;
            WorldInfo.Corridor1Timer();
        }
    }

    private void Update()
    {
        if(scene.name == "Corridor1")
        {
            if (WorldInfo.corridor1TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor1TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor1TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        if (scene.name == "Hub")
        {
            AllowedentryText = GameObject.Find("AllowedText").GetComponent<Text>();
        }        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Corridor1"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor1AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor1");
                    }

                }
            }



        }


        if (other.gameObject.CompareTag("Hub"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if(scene.name == "Corridor1")
                {
                    WorldInfo.Corridor1Timer();
                }

                SceneManager.LoadScene("Hub");
            }
        }

    }

    public void KickOutofCorridor1()
    {

        SceneManager.LoadScene("Hub");  

    }


    public void StartGhostChase()
    {
        
        Instantiate(ghostPrefab, new Vector3(14, 2, 13), Quaternion.identity);

    }




}
