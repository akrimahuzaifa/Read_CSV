using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleInstantiator : MonoBehaviour
{
    public TextAsset textAssetData;
    public Toggle togglePrefab;
    public GameObject parentPanel;
  /*  [System.Serializable]
    public class ToggleText
    {
        public string name;
    }*/
/*    [System.Serializable]
    public class ToggleTextList
    {
        public String[] toggleText;
    }
    
    ToggleTextList myToggleTextList = new ToggleTextList();*/

    private void Start()
    {
        ReadDataCSV();
    }

    void ReadDataCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        Debug.Log("AHA: " + data[4]);
        int tableSize = data.Length / 1;
        //myToggleTextList.toggleText = new String[tableSize];
        GameObject toggleHolder;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] != "")
            {
                /*myToggleTextList.toggleText[i] = new ToggleText();*/
                //myToggleTextList.toggleText[i] = data[i];
                toggleHolder = Instantiate(togglePrefab.gameObject, parentPanel.transform);
                var label = parentPanel.transform.GetChild(i).gameObject.transform.GetChild(1).gameObject;
                label.GetComponent<Text>().text = data[i];
            }
        }
        Debug.Log("Size: " + tableSize);
        Debug.Log("Element: " + data[19]);
    }
}
