using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class scr_ChangeScene : MonoBehaviour
{
    public Scene scene;
    scr_WorldInformation WorldInfo;

    public GameObject ghostPrefab;

    public Text timerText;
    public Text AllowedentryText1;
    public Text AllowedentryText2;
    public Text AllowedentryText3;
    public Text AllowedentryText4;
    public Text AllowedentryText5;
    public Text AllowedentryText6;
    public Text AllowedentryText7;
    public Text AllowedentryText8;

    private void Awake()
    {
        WorldInfo = GameObject.FindObjectOfType<scr_WorldInformation>();
        scene = SceneManager.GetActiveScene();


        if(scene.name == "Corridor1")
        {
            WorldInfo.timerPause1 = false;
            WorldInfo.increaseTimer1 = false;
            WorldInfo.Corridor1Timer();
        }

        if (scene.name == "Corridor2")
        {
            WorldInfo.timerPause2 = false;
            WorldInfo.increaseTimer2 = false;
            WorldInfo.Corridor2Timer();
        }
        if (scene.name == "Corridor3")
        {
            WorldInfo.timerPause3 = false;
            WorldInfo.increaseTimer3 = false;
            WorldInfo.Corridor3Timer();
        }
        if (scene.name == "Corridor4")
        {
            WorldInfo.timerPause4 = false;
            WorldInfo.increaseTimer4 = false;
            WorldInfo.Corridor4Timer();
        }
        if (scene.name == "Corridor5")
        {
            WorldInfo.timerPause5 = false;
            WorldInfo.increaseTimer5 = false;
            WorldInfo.Corridor5Timer();
        }
        if (scene.name == "Corridor6")
        {
            WorldInfo.timerPause6 = false;
            WorldInfo.increaseTimer6 = false;
            WorldInfo.Corridor6Timer();
        }
        if (scene.name == "Corridor7")
        {
            WorldInfo.timerPause7 = false;
            WorldInfo.increaseTimer7 = false;
            WorldInfo.Corridor7Timer();
        }
        if (scene.name == "Corridor8")
        {
            WorldInfo.timerPause8 = false;
            WorldInfo.increaseTimer8 = false;
            WorldInfo.Corridor8Timer();
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
        else if (scene.name == "Corridor2")
        {
            if (WorldInfo.corridor2TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor2TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor2TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor3")
        {
            if (WorldInfo.corridor3TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor3TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor3TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor4")
        {
            if (WorldInfo.corridor4TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor4TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor4TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor5")
        {
            if (WorldInfo.corridor5TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor5TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor5TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor6")
        {
            if (WorldInfo.corridor6TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor6TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor6TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor7")
        {
            if (WorldInfo.corridor7TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor7TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor7TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else if (scene.name == "Corridor8")
        {
            if (WorldInfo.corridor8TimeLeft <= 0)
            {
                timerText.text = "Time's Up! Run!";
            }
            else if (WorldInfo.corridor8TimeLeft > 0)
            {
                timerText.text = WorldInfo.corridor8TimeLeft.ToString("f2") + " Seconds Left";
            }
        }
        else        
        {
            AllowedentryText1 = GameObject.Find("AllowedText1").GetComponent<Text>();
            AllowedentryText2 = GameObject.Find("AllowedText2").GetComponent<Text>();
            AllowedentryText3 = GameObject.Find("AllowedText3").GetComponent<Text>();
            AllowedentryText4 = GameObject.Find("AllowedText4").GetComponent<Text>();
            AllowedentryText5 = GameObject.Find("AllowedText5").GetComponent<Text>();
            AllowedentryText6 = GameObject.Find("AllowedText6").GetComponent<Text>();
            AllowedentryText7 = GameObject.Find("AllowedText7").GetComponent<Text>();
            AllowedentryText8 = GameObject.Find("AllowedText8").GetComponent<Text>();

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
        else if (other.gameObject.CompareTag("Corridor2"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor2AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor2");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor3"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor3AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor3");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor4"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor4AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor4");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor5"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor5AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor5");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor6"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor6AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor6");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor7"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor7AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor7");
                    }

                }
            }

        }
        else if (other.gameObject.CompareTag("Corridor8"))
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (scene.name == "Hub")
                {
                    if (WorldInfo.corridor8AllowedEntry == true)
                    {

                        SceneManager.LoadScene("Corridor8");
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

                if (scene.name == "Corridor2")
                {
                    WorldInfo.Corridor2Timer();
                }
                if (scene.name == "Corridor3")
                {
                    WorldInfo.Corridor3Timer();
                }
                if (scene.name == "Corridor4")
                {
                    WorldInfo.Corridor4Timer();
                }
                if (scene.name == "Corridor5")
                {
                    WorldInfo.Corridor5Timer();
                }
                if (scene.name == "Corridor6")
                {
                    WorldInfo.Corridor6Timer();
                }
                if (scene.name == "Corridor7")
                {
                    WorldInfo.Corridor7Timer();
                }
                if (scene.name == "Corridor8")
                {
                    WorldInfo.Corridor8Timer();
                }
                SceneManager.LoadScene("Hub");
            }
        }

    }

    public void KickOutofCorridor()
    {

        SceneManager.LoadScene("Hub");  

    }


    public void StartGhostChase()
    {
        
        Instantiate(ghostPrefab, new Vector3(60, 2, -30), Quaternion.identity);

    }




}
