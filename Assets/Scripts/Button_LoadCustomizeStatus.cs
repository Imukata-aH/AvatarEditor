using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Button_LoadCustomizeStatus : MonoBehaviour {

    public GameObject CustomizeStatusManagerObject;

    public void OnPressedLoadButton()
    {
        if (this.CustomizeStatusManagerObject == null)
        {
            Debug.LogError("CustomizeStatusManagerObject instance is not set.");
            return;
        }

        var stateManager = this.CustomizeStatusManagerObject.GetComponent<AvatarCustomizeStateManager>();
        if (stateManager == null)
        {
            Debug.LogError("CustomizeStatusManagerObject doesn't have a component AvatarCustomizeStatus");
            return;
        }

        if (File.Exists(CustomizeEditorConstants.FilePath2CusomizeData))
        {
            string jsonCustomizeData = "";
            using (var streamReader = new StreamReader(CustomizeEditorConstants.FilePath2CusomizeData))
            {
                jsonCustomizeData = streamReader.ReadToEnd();
            }
            if (!string.IsNullOrEmpty(jsonCustomizeData))
            {
                AvatarCustomizeStatus customizeState = JsonUtility.FromJson<AvatarCustomizeStatus>(jsonCustomizeData);
                stateManager.ReplaceCustomizeState(customizeState);
                Debug.Log("Loaded customize status.");
                // Utilities.ShowJsonData(jsonCustomizeData);   // TODO: JSONの中身を表示
            }
        }
    }
}
