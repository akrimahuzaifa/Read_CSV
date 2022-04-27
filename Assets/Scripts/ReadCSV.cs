using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadCSV : MonoBehaviour
{
    void Start()
    {
        ReadCSVFile();
    }
    void ReadCSVFile()
    {
        StreamReader strReader = new StreamReader("D:/@Tll_Training/Read_CSV/Assets/CSVFiles/GAME2.csv");
        bool endOfFile = false;
        while (!endOfFile)
        {
            string dataString = strReader.ReadLine();
            if(dataString == null)
            {
                endOfFile = true;
                break;
            }
            var dataValues = dataString.Split(",");
/*            for(int i = 0; i < dataValues.Length; i++)
            {
                Debug.Log("Values: " + i.ToString() + " " + dataValues[i].ToString());
            }*/

            Debug.Log(  dataValues[0].ToString() + " " + 
                        dataValues[1].ToString() + " " + 
                        dataValues[2].ToString() + " " + 
                        dataValues[3].ToString()
                      );
        }
    }
}
