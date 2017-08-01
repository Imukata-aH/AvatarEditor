using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_CustomizeStateSave : MonoBehaviour {

    public GameObject CustomizeStatusObject;

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
        Debug.LogFormat("Customize Status: {0}", json);
    }
}
