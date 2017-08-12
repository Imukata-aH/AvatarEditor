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
            string jsonData = "";
            using (var streamReader = new StreamReader(filePath))
            {
                jsonData = streamReader.ReadToEnd();
            }
            if (!string.IsNullOrEmpty(jsonData))
            {
                ret = JsonUtility.FromJson<T>(jsonData);
                Debug.LogFormat("Loaded customize status.\n{0}", jsonData);
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
        Debug.LogFormat("Saved customize status.\n{0}", json);
    }
}
