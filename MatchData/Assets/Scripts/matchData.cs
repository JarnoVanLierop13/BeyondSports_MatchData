using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System;

[Serializable]
public class matchData : MonoBehaviour
{
    private string jsonString;
    private JsonData fileData;

    private void Start()
    {
        jsonString = File.ReadAllText( Application.dataPath + "/Resources/match_data.json");
        fileData = JsonMapper.ToObject(jsonString);
        Debug.Log(fileData);
    }

}
