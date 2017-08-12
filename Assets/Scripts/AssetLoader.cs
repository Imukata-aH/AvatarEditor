using System;
using System.IO;
using UnityEngine;

public class AssetLoader : MonoBehaviour
{
    public static void UnLoadAsset(GameObject gameObject)
    {
        if(gameObject == null)
        {
            return;
        }

        Destroy(gameObject);
    }

    public static GameObject LoadAsset(uint assetID)
    {
        // TODO: ここでアセットの所在（ローカル or リモート）を見てアセットロード
        string path = Path.Combine(Path.Combine(CustomizeEditorConstants.AvatarAssetResourcesDirName, assetID.ToString()), CustomizeEditorConstants.CommonAssetName);
        var asset = Resources.Load<GameObject>(path);
        if(asset != null)
        {
            asset.name = assetID.ToString();
            return Instantiate(asset);
        }
        return null;
    }
}