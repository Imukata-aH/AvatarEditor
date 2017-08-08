using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_SaveCustomizeStatus : MonoBehaviour {

    public GameObject CustomizeStatusManagerObject;

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
            using (var sw = File.CreateText(CustomizeEditorConstants.FilePath2CusomizeData))
            {
                sw.Write(json);
            }
            // Utilities.ShowJsonData(json);   // TODO: JSONの中身を表示
            Debug.Log("Saved customize status.");
        }
    }
}
