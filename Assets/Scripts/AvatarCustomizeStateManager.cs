using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarCustomizeStateManager : MonoBehaviour {

    private AvatarCustomizeStatus customizeState;

    private void Awake()
    {
        this.customizeState = new AvatarCustomizeStatus();
    }

    // FIXME: 外部でStateオブジェクトを触ってほしくないが… コピーを渡す？
    public AvatarCustomizeStatus GetCustomizeStatus()
    {
        return this.customizeState;
    }

    public void ReplaceCustomizeState(AvatarCustomizeStatus newState)
    {
        this.customizeState = newState;
    }
}
