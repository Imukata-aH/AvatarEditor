using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_CustomizeStateSave : MonoBehaviour {

    private static string saveFilePath;

    public GameObject CustomizeStatusManagerObject;

    private void Awake()
    {
        saveFilePath = Path.Combine(Application.dataPath, "CustomizeData/avatar_customize_data.json");
    }

    public void OnPressedSaveButton()
    {
        if(this.CustomizeStatusManagerObject == null)
        {
            Debug.LogError("CustomizeStatusManagerObject instance is not set.");
            return;
        }

        var stateManager = this.CustomizeStatusManagerObject.GetComponent<AvatarCustomizeStateManager>();
        if(stateManager == null)
        {
            Debug.LogError("CustomizeStatusManagerObject doesn't have a component AvatarCustomizeStatus");
            return;
        }

        AvatarCustomizeStatus state = stateManager.GetCustomizeStatus();

        if (state != null)
        {
            string json = JsonUtility.ToJson(state, true);
            using (var sw = File.CreateText(saveFilePath))
            {
                sw.Write(json);
            }
        }
    }
}
