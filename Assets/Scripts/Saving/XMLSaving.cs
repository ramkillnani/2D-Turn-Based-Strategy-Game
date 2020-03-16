using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

public static class XMLSaving
{
    public static SaveData ReadData()
    {
        //New string path that is the applications data path with /Highscore.sav
        string path = Application.persistentDataPath + "/SaveData.XML";
        //If the file path exists
        if (File.Exists(path))
        {
            //New XML serializer for highsocores data
            var serializer = new XmlSerializer(typeof(SaveData));
            //New file stream to open file at path location
            var stream = new FileStream(path, FileMode.Open);
            //New container for the data to deserialize as highscores
            var container = serializer.Deserialize(stream) as SaveData;
            //Close the stream
            stream.Close();
            //Return the container
            return container;
        }
        else
        {
            //Return null
            return null;
        }
    }

    public static void WriteData(SaveData data)
    {
        //New XML serializer for highsocores data
        var serializer = new XmlSerializer(typeof(SaveData));
        //New string path that is the applications data path with /Highscore.sav
        string path = Application.persistentDataPath + "/SaveData.XML";
        //New file stream at path location
        var stream = new FileStream(path, FileMode.Create);
        //serialze the data
        serializer.Serialize(stream, data);
        //Close Stream
        stream.Close();
    }
}