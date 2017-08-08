using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_CustomizeAvatar : MonoBehaviour {

    public uint AssetID
    {
        get;
        private set;
    }

    public void LoadTargetAssetData(uint assetIndex)
    {
        this.AssetID = assetIndex;

        AssetMetaData metadata = LoadAssetMetadata(assetIndex);
        Sprite assetImage = LoadAssetImage(assetIndex);
        Image assetImageBox = this.GetComponent<Image>();
        assetImageBox.sprite = assetImage;

        string assetName = metadata.AssetName;
        Text assetNameBox = this.GetComponent<Text>();
        assetNameBox.text = assetName;
    }

    private AssetMetaData LoadAssetMetadata(uint assetIndex)
    {
        throw new NotImplementedException();
    }

    private Sprite LoadAssetImage(uint assetIndex)
    {
        throw new NotImplementedException();
    }
}
