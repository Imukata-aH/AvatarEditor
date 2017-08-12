using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarCustomizeStateManager : MonoBehaviour {

    private AvatarCustomizeStatus customizeState;
    private Dictionary<uint, GameObject> loadedAvatarAssetDic = new Dictionary<uint, GameObject>();

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

    public void SetCustomizeState(CustomizePartsCategory partsCategory, uint assetID)
    {
        uint prevAssetID = this.customizeState.GetCustomizeState(partsCategory);

        if (this.loadedAvatarAssetDic.ContainsKey(prevAssetID))
        {
            AssetLoader.UnLoadAsset(this.loadedAvatarAssetDic[prevAssetID]);
            this.loadedAvatarAssetDic[prevAssetID] = null;
            this.loadedAvatarAssetDic.Remove(prevAssetID);
        }

        if (prevAssetID == assetID)
        {
            // すでに装着済みのパーツを再選択したら脱がす(デフォルト0にする)
            this.customizeState.SetCustomizeState(partsCategory, 0);
        }
        else
        {
            this.customizeState.SetCustomizeState(partsCategory, assetID);
            var asset = AssetLoader.LoadAsset(assetID);
            this.loadedAvatarAssetDic[assetID] = asset;
        }
    }
}
