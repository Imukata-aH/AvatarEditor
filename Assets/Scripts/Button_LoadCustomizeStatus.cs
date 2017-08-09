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

        var customizeState = Utilities.LoadJsonFromFile<AvatarCustomizeStatus>(CustomizeEditorConstants.FilePath2CusomizeData);
        if(customizeState != null)
        {
            stateManager.ReplaceCustomizeState(customizeState);
        }
    }
}
