using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public static class scr_SaveToFile
{

    public static void SaveInformation (scr_WorldInformation saveInformation)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/worldinformation.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        scr_PlayerData data = new scr_PlayerData(saveInformation);

        Debug.Log("save to file " + data.Corridor1AllowedEntry + data.Corridor1TimeLeft + data.IncreaseTimer1);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static scr_PlayerData LoadInformation()
    {
        string path = Application.persistentDataPath + "/worldinformation.save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            scr_PlayerData data = formatter.Deserialize(stream) as scr_PlayerData;
            stream.Close();

            Debug.Log("load from file " + data.Corridor1AllowedEntry + data.Corridor1TimeLeft + data.IncreaseTimer1);

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
