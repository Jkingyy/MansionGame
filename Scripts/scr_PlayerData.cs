using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class scr_PlayerData
{

    public float Corridor1TimeLeft;
    public bool Corridor1AllowedEntry;
    public bool IncreaseTimer1;



    public scr_PlayerData(scr_WorldInformation saveData)
    {
        Corridor1AllowedEntry = saveData.corridor1AllowedEntry;
        Corridor1TimeLeft = saveData.corridor1TimeLeft;
        IncreaseTimer1 = saveData.increaseTimer1;

        Debug.Log("player data " + Corridor1AllowedEntry + Corridor1TimeLeft);
    }

}
