using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

public class CustomizeEditorConstants : MonoBehaviour
{
    public static readonly string FilePath2CusomizeData = Path.Combine(Application.dataPath, "CustomizeData/avatar_customize_data.json");

    public static readonly string DirectoryPath2AssetData = Path.Combine(Application.dataPath, "AvatarAsset/AssetData");

    public static readonly string FilenameAssetMetadata = "asset_metadata.json";
}
