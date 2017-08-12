using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

public class CustomizeEditorConstants : MonoBehaviour
{
    public static readonly string FilePath2CusomizeData = Path.Combine(Application.dataPath, "CustomizeData/avatar_customize_data.json");

    public static readonly string AvatarAssetResourcesDirName = "AvatarAsset";

    public static readonly string DirectoryPath2AssetData = Path.Combine(Application.dataPath, Path.Combine("Resources", AvatarAssetResourcesDirName));

    public static readonly string FilenameAssetMetadata = "asset_metadata.json";

    public static readonly string ThumbnailFilename = "thumb";

    public static readonly string CommonAssetName = "asset";
}
