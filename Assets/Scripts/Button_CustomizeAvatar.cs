using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_CustomizeAvatar : MonoBehaviour {

    public uint AssetID;

    private CustomizePartsCategory partsCategory;

    public void LoadTargetAssetData(uint assetIndex)
    {
        this.AssetID = assetIndex;

        AssetMetaData metadata = LoadAssetMetadata(assetIndex);

        if (metadata != null)
        {
            string assetName = metadata.AssetName;
            Text assetNameBox = this.transform.Find("AssetNameText").GetComponent<Text>();
            assetNameBox.text = assetName;

            this.partsCategory = (CustomizePartsCategory)metadata.AssetCategory;

            Sprite assetImage = LoadAssetImage(assetIndex);
            Image assetImageBox = this.transform.Find("AssetThumbImage").GetComponent<Image>();
            assetImageBox.sprite = assetImage;
        }
    }

    private AssetMetaData LoadAssetMetadata(uint assetIndex)
    {
        return Utilities.LoadJsonFromFile<AssetMetaData>(Path.Combine(Path.Combine(CustomizeEditorConstants.DirectoryPath2AssetData, assetIndex.ToString()), CustomizeEditorConstants.FilenameAssetMetadata));
    }

    private Sprite LoadAssetImage(uint assetIndex)
    {
        return Resources.Load<Sprite>(Path.Combine(Path.Combine(CustomizeEditorConstants.AvatarAssetResourcesDirName, assetIndex.ToString()), CustomizeEditorConstants.ThumbnailFilename));

    }

    private void Start()
    {
        // for test.
        LoadTargetAssetData(this.AssetID);
    }
}
