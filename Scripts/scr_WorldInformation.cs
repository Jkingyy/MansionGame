using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scr_WorldInformation : MonoBehaviour
{

    public static scr_WorldInformation worldInfo;



    public float corridor1Time;
    public float corridor1TimeLeft;
    public float timeTilAllowed1;
    public bool inCorridor1;
    public bool corridor1KickedOut;
    public bool corridor1AllowedEntry;


    public float corridor2Time;
    public float corridor2TimeLeft;
    public float timeTilAllowed2;
    public bool inCorridor2;
    public bool corridor2KickedOut;
    public bool corridor2AllowedEntry;

    public float corridor3Time;
    public float corridor3TimeLeft;
    public float timeTilAllowed3;
    public bool inCorridor3;
    public bool corridor3KickedOut;
    public bool corridor3AllowedEntry;

    public float corridor4Time;
    public float corridor4TimeLeft;
    public float timeTilAllowed4;
    public bool inCorridor4;
    public bool corridor4KickedOut;
    public bool corridor4AllowedEntry;

    public float corridor5Time;
    public float corridor5TimeLeft;
    public float timeTilAllowed5;
    public bool inCorridor5;
    public bool corridor5KickedOut;
    public bool corridor5AllowedEntry;

    public float corridor6Time;
    public float corridor6TimeLeft;
    public float timeTilAllowed6;
    public bool inCorridor6;
    public bool corridor6KickedOut;
    public bool corridor6AllowedEntry;

    public float corridor7Time;
    public float corridor7TimeLeft;
    public float timeTilAllowed7;
    public bool inCorridor7;
    public bool corridor7KickedOut;
    public bool corridor7AllowedEntry;

    public float corridor8Time;
    public float corridor8TimeLeft;
    public float timeTilAllowed8;
    public bool inCorridor8;
    public bool corridor8KickedOut;
    public bool corridor8AllowedEntry;


    public bool timerPause1 = true;
    public bool timerPause2 = true;
    public bool timerPause3 = true;
    public bool timerPause4 = true;
    public bool timerPause5 = true;
    public bool timerPause6 = true;
    public bool timerPause7 = true;
    public bool timerPause8 = true;

    public bool increaseTimer1;
    public bool increaseTimer2;
    public bool increaseTimer3;
    public bool increaseTimer4;
    public bool increaseTimer5;
    public bool increaseTimer6;
    public bool increaseTimer7;
    public bool increaseTimer8;

    public scr_ChangeScene ChangeScene;

    public bool corridor1Door1Key = false;
    public bool corridor1Door2Key = false;
    public bool corridor1Door3Key = false;
    public bool corridor1Door5Key = false;
    public bool corridor1Door6Key = false;
    public bool corridor1Door7Key = false;

    public bool corridor2Door1Key = false;
    public bool corridor2Door2Key = false;
    public bool corridor2Door3Key = false;
    public bool corridor2Door4Key = false;
    public bool corridor2Door5Key = false;
    public bool corridor2Door6Key = false;
    public bool corridor2Door7Key = false;

    public bool corridor3Door1Key = false;
    public bool corridor3Door2Key = false;
    public bool corridor3Door3Key = false;
    public bool corridor3Door4Key = false;
    public bool corridor3Door5Key = false;
    public bool corridor3Door6Key = false;
    public bool corridor3Door8Key = false;

    public bool corridor4Door1Key = false;
    public bool corridor4Door2Key = false;
    public bool corridor4Door3Key = false;
    public bool corridor4Door4Key = false;
    public bool corridor4Door5Key = false;
    public bool corridor4Door6Key = false;
    public bool corridor4Door7Key = false;
    public bool corridor4Door8Key = false;
    public bool corridor4Door9Key = false;
    public bool corridor4Door10Key = false;

    public bool corridor5Door1Key = false;
    public bool corridor5Door2Key = false;
    public bool corridor5Door3Key = false;
    public bool corridor5Door4Key = false;
    public bool corridor5Door5Key = false;
    public bool corridor5Door6Key = false;
    public bool corridor5Door7Key = false;

    public bool corridor6Door1Key = false;
    public bool corridor6Door2Key = false;
    public bool corridor6Door3Key = false;
    public bool corridor6Door4Key = false;
    public bool corridor6Door5Key = false;
    public bool corridor6Door6Key = false;
    public bool corridor6Door7Key = false;
    public bool corridor6Door8Key = false;

    public bool corridor7Door1Key = false;
    public bool corridor7Door2Key = false;
    public bool corridor7Door3Key = false;
    public bool corridor7Door4Key = false;
    public bool corridor7Door5Key = false;
    public bool corridor7Door6Key = false;
    public bool corridor7Door7Key = false;
    public bool corridor7Door8Key = false;

    public bool corridor8Door1Key = false;
    public bool corridor8Door2Key = false;
    public bool corridor8Door3Key = false;
    public bool corridor8Door4Key = false;
    public bool corridor8Door5Key = false;
    public bool corridor8Door6Key = false;
    public bool corridor8Door7Key = false;
    public bool corridor8Door8Key = false;
    public bool corridor8Door9Key = false;
    public bool corridor8Door10Key = false;

    private void Awake()
    {


        if (worldInfo == null)
        {
            DontDestroyOnLoad(gameObject);
            worldInfo = this;
        }
        else if (worldInfo != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeScene = GameObject.FindObjectOfType<scr_ChangeScene>();


        if (inCorridor1 == true)
        {
            if (timerPause1 == false)
            {
                if (increaseTimer1 == false)
                {
                    corridor1TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor1TimeLeft < 0 && corridor1KickedOut == false && timerPause1 == false && increaseTimer1 == false)
            {
                timerPause1 = true;
    
                inCorridor1 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor2 == true)
        {
            if (timerPause2 == false)
            {
                if (increaseTimer2 == false)
                {
                    corridor2TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor2TimeLeft < 0 && corridor2KickedOut == false && timerPause2 == false && increaseTimer2 == false)
            {
                timerPause2 = true;

                inCorridor2 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor3 == true)
        {
            if (timerPause3 == false)
            {
                if (increaseTimer3 == false)
                {
                    corridor3TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor3TimeLeft < 0 && corridor3KickedOut == false && timerPause3 == false && increaseTimer3 == false)
            {
                timerPause3 = true;

                inCorridor3 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor4 == true)
        {
            if (timerPause4 == false)
            {
                if (increaseTimer4 == false)
                {
                    corridor4TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor4TimeLeft < 0 && corridor4KickedOut == false && timerPause4 == false && increaseTimer4 == false)
            {
                timerPause4 = true;

                inCorridor4 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor5 == true)
        {
            if (timerPause5 == false)
            {
                if (increaseTimer5 == false)
                {
                    corridor5TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor5TimeLeft < 0 && corridor5KickedOut == false && timerPause5 == false && increaseTimer5 == false)
            {
                timerPause5 = true;

                inCorridor5 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor6 == true)
        {
            if (timerPause6 == false)
            {
                if (increaseTimer6 == false)
                {
                    corridor6TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor6TimeLeft < 0 && corridor6KickedOut == false && timerPause6 == false && increaseTimer6 == false)
            {
                timerPause6 = true;

                inCorridor6 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor7 == true)
        {
            if (timerPause7 == false)
            {
                if (increaseTimer7 == false)
                {
                    corridor7TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor7TimeLeft < 0 && corridor7KickedOut == false && timerPause7 == false && increaseTimer7 == false)
            {
                timerPause7 = true;

                inCorridor7 = false;
                ChangeScene.StartGhostChase();


            }
        }
        else if (inCorridor8 == true)
        {
            if (timerPause8 == false)
            {
                if (increaseTimer8 == false)
                {
                    corridor8TimeLeft -= Time.deltaTime;
                }
            }
            if (corridor8TimeLeft < 0 && corridor8KickedOut == false && timerPause8 == false && increaseTimer8 == false)
            {
                timerPause8 = true;

                inCorridor8 = false;
                ChangeScene.StartGhostChase();


            }
        }

        else
        {
            if (increaseTimer1 == true && timerPause1 == false)
            {
                corridor1TimeLeft += Time.deltaTime;
            }
            
            if (corridor1TimeLeft > timeTilAllowed1 && increaseTimer1 == true)
            {
  
                corridor1TimeLeft = corridor1Time;
                corridor1AllowedEntry = true;
                corridor1KickedOut = false;

            }

            if (increaseTimer2 == true && timerPause2 == false)
            {
                corridor2TimeLeft += Time.deltaTime;
            }

            if (corridor2TimeLeft > timeTilAllowed2 && increaseTimer2 == true)
            {

                corridor2TimeLeft = corridor2Time;
                corridor2AllowedEntry = true;
                corridor2KickedOut = false;

            }

            if (increaseTimer3 == true && timerPause3 == false)
            {
                corridor3TimeLeft += Time.deltaTime;
            }

            if (corridor3TimeLeft > timeTilAllowed3 && increaseTimer3 == true)
            {

                corridor3TimeLeft = corridor2Time;
                corridor3AllowedEntry = true;
                corridor3KickedOut = false;

            }

            if (increaseTimer4 == true && timerPause4 == false)
            {
                corridor4TimeLeft += Time.deltaTime;
            }

            if (corridor4TimeLeft > timeTilAllowed4 && increaseTimer4 == true)
            {

                corridor4TimeLeft = corridor2Time;
                corridor4AllowedEntry = true;
                corridor4KickedOut = false;

            }

            if (increaseTimer5 == true && timerPause5 == false)
            {
                corridor5TimeLeft += Time.deltaTime;
            }

            if (corridor5TimeLeft > timeTilAllowed5 && increaseTimer5 == true)
            {

                corridor5TimeLeft = corridor2Time;
                corridor5AllowedEntry = true;
                corridor5KickedOut = false;

            }

            if (increaseTimer6 == true && timerPause6 == false)
            {
                corridor6TimeLeft += Time.deltaTime;
            }

            if (corridor6TimeLeft > timeTilAllowed6 && increaseTimer6 == true)
            {

                corridor6TimeLeft = corridor2Time;
                corridor6AllowedEntry = true;
                corridor6KickedOut = false;

            }

            if (increaseTimer7 == true && timerPause7 == false)
            {
                corridor7TimeLeft += Time.deltaTime;
            }

            if (corridor7TimeLeft > timeTilAllowed7 && increaseTimer7 == true)
            {

                corridor7TimeLeft = corridor2Time;
                corridor7AllowedEntry = true;
                corridor7KickedOut = false;

            }

            if (increaseTimer8 == true && timerPause8 == false)
            {
                corridor8TimeLeft += Time.deltaTime;
            }

            if (corridor8TimeLeft > timeTilAllowed8 && increaseTimer8 == true)
            {

                corridor8TimeLeft = corridor2Time;
                corridor8AllowedEntry = true;
                corridor8KickedOut = false;

            }
        }

        if(corridor1KickedOut == true)
        {
            corridor1AllowedEntry = false;
            timerPause1 = false;
            corridor1KickedOut = false;
            increaseTimer1 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor2KickedOut == true)
        {
            corridor2AllowedEntry = false;
            timerPause2 = false;
            corridor2KickedOut = false;
            increaseTimer2 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor3KickedOut == true)
        {
            corridor3AllowedEntry = false;
            timerPause3 = false;
            corridor3KickedOut = false;
            increaseTimer3 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor4KickedOut == true)
        {
            corridor4AllowedEntry = false;
            timerPause4 = false;
            corridor4KickedOut = false;
            increaseTimer4 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor5KickedOut == true)
        {
            corridor5AllowedEntry = false;
            timerPause5 = false;
            corridor5KickedOut = false;
            increaseTimer5 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor6KickedOut == true)
        {
            corridor6AllowedEntry = false;
            timerPause6 = false;
            corridor6KickedOut = false;
            increaseTimer6 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor7KickedOut == true)
        {
            corridor7AllowedEntry = false;
            timerPause7 = false;
            corridor7KickedOut = false;
            increaseTimer7 = true;
            ChangeScene.KickOutofCorridor();
        }

        if (corridor8KickedOut == true)
        {
            corridor8AllowedEntry = false;
            timerPause8 = false;
            corridor8KickedOut = false;
            increaseTimer8 = true;
            ChangeScene.KickOutofCorridor();
        }



    }



    public void Corridor1Timer()
    {
        if(inCorridor1 == true)
        {
            inCorridor1 = false;
        }
        else
        {
            inCorridor1 = true;
        }
    }

    public void Corridor2Timer()
    {
        if (inCorridor2 == true)
        {
            inCorridor2 = false;
        }
        else
        {
            inCorridor2 = true;
        }
    }

    public void Corridor3Timer()
    {
        if (inCorridor3 == true)
        {
            inCorridor3 = false;
        }
        else
        {
            inCorridor3 = true;
        }
    }

    public void Corridor4Timer()
    {
        if (inCorridor4 == true)
        {
            inCorridor4 = false;
        }
        else
        {
            inCorridor4 = true;
        }
    }

    public void Corridor5Timer()
    {
        if (inCorridor5 == true)
        {
            inCorridor5 = false;
        }
        else
        {
            inCorridor5 = true;
        }
    }

    public void Corridor6Timer()
    {
        if (inCorridor6 == true)
        {
            inCorridor6 = false;
        }
        else
        {
            inCorridor6 = true;
        }
    }

    public void Corridor7Timer()
    {
        if (inCorridor7 == true)
        {
            inCorridor7 = false;
        }
        else
        {
            inCorridor7 = true;
        }
    }

    public void Corridor8Timer()
    {
        if (inCorridor8 == true)
        {
            inCorridor8 = false;
        }
        else
        {
            inCorridor8 = true;
        }
    }




    public void SavePlayer()
    {
        scr_SaveToFile.SaveInformation(this);
    }

    public void LoadPlayer()
    {
        scr_PlayerData data = scr_SaveToFile.LoadInformation();

        corridor1AllowedEntry = data.Corridor1AllowedEntry;
        corridor1TimeLeft = data.Corridor1TimeLeft;
        increaseTimer1 = data.IncreaseTimer1;
    }

}
