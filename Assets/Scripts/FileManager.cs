using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class FileManager : MonoBehaviour
{
    string path;
    public RawImage rawImage;
    //public Text text;

    public void OpenFileExplorer()
    {
        path = EditorUtility.OpenFilePanel("Show All PNG Files(.png)", "", "png");
        
        StartCoroutine(GetTexture());
    }

    IEnumerator GetTexture()
    {
        
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("file:///" + path);
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            rawImage.texture = myTexture;
            /*            string myText = ((DownloadHandlerFile)www.downloadHandler).text;
                        text.text = myText;*/

        }
    }
}
