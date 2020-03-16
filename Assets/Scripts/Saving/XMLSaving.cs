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
        
        string path = Application.persistentDataPath + "/SaveData.XML";
        //If the file path exists
        if (File.Exists(path))
        {
            
            var serializer = new XmlSerializer(typeof(SaveData));
            //New file stream to open file at path location
            var stream = new FileStream(path, FileMode.Open);
            
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
       
        var serializer = new XmlSerializer(typeof(SaveData));
        
        string path = Application.persistentDataPath + "/SaveData.XML";
        //New file stream at path location
        var stream = new FileStream(path, FileMode.Create);
        //serialze the data
        serializer.Serialize(stream, data);
        //Close Stream
        stream.Close();
    }
}