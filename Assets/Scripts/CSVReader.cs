using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSVReader : MonoBehaviour
{
    public TextAsset textAssestData;

    [System.Serializable]
    public class Player
    {
        public string name;
        public int health;
        public int damage;
        public int defence;
    }
    [System.Serializable]
    public class PlayerList
    {
        public Player[] player;
    }

    public PlayerList myPlayerlist = new PlayerList();

    void Start()
    {
        ReadCSV();
    }

    void ReadCSV()
    {
        Debug.Log("TextAsset: " + textAssestData);
        string[] data = textAssestData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        Debug.Log("AHA: " + data[4]);

        int tableSize = data.Length / 4 - 1;
        myPlayerlist.player = new Player[tableSize];

        for (int i = 0; i < tableSize; i++)
        {
            myPlayerlist.player[i] = new Player();
            myPlayerlist.player[i].name = data[4 * (i + 1)];
            myPlayerlist.player[i].health = int.Parse(data[4 * (i + 1) + 1]);
            myPlayerlist.player[i].damage = int.Parse(data[4 * (i + 1) + 1 + 1]);
            myPlayerlist.player[i].defence = int.Parse(data[4 * (i + 1) + 1 + 1 + 1]);
        }
    }
}
