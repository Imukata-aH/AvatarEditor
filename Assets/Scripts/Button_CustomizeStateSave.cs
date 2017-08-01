using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_CustomizeStateSave : MonoBehaviour {

    private static string saveFilePath;

    public GameObject CustomizeStatusObject;

    private void Awake()
    {
        saveFilePath = Path.Combine(Application.dataPath, "CustomizeData/avatar_customize_data.json");
    }

    public void OnPressedSaveButton()
    {
        if(this.CustomizeStatusObject == null)
        {
            Debug.LogError("CustomizeStatusObject instance is not set.");
            return;
        }

        var state = this.CustomizeStatusObject.GetComponent<AvatarCustomizeStatus>();
        if(state == null)
        {
            Debug.LogError("CustomizeStatusObject doesn't have a component AvatarCustomizeStatus");
            return;
        }

        string json = JsonUtility.ToJson(state, true);
        using (var sw = File.CreateText(saveFilePath))
        {
            sw.Write(json);
        }

    }
}
