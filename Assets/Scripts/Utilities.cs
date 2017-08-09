using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

public class Utilities
{
    public static T LoadJsonFromFile<T>(string filePath)
    {
        T ret = default(T);

        if (File.Exists(filePath))
        {
            string jsonCustomizeData = "";
            using (var streamReader = new StreamReader(CustomizeEditorConstants.FilePath2CusomizeData))
            {
                jsonCustomizeData = streamReader.ReadToEnd();
            }
            if (!string.IsNullOrEmpty(jsonCustomizeData))
            {
                T customizeState = JsonUtility.FromJson<T>(jsonCustomizeData);
                Debug.Log("Loaded customize status.");
                // Utilities.ShowJsonData(jsonCustomizeData);   // TODO: JSONの中身を表示
            }
        }

        return ret;
    }

    public static void WriteJsonToFile<T>(string filePath, T jsonObject)
    {
        string json = JsonUtility.ToJson(jsonObject, true);
        using (var sw = File.CreateText(filePath))
        {
            sw.Write(json);
        }
        // Utilities.ShowJsonData(json);   // TODO: JSONの中身を表示
        Debug.Log("Saved customize status.");
    }
}
