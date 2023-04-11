using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class TextFile : MonoBehaviour
{
    public InputField inputFieldChat;

    void Start()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Chat Logs/");
        CreateTextFile();
    }
    public void CreateTextFile()
    {
       
    }
}
