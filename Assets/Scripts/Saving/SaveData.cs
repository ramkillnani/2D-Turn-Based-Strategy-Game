﻿using System.Xml.Serialization;
[System.Serializable]
public class SaveData
{
    [XmlAttribute("Names")]
    //String array for storing player names
    public string[] playerName = new string[10] { "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank", "Blank" };
    [XmlAttribute("Level")]
    //String array for storing waves they did
    public int[] level = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    [XmlAttribute("Turn")]
    //String array for storing waves they did
    public int[] turn = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

}
