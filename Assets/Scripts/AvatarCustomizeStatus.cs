using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CustomizePartsType
{
    TopsModel,
    BottomsModel,
    ShoesModel,
}

[System.Serializable]
public class AvatarCustomizeStatus
{
    public int TopsModel;
    public int BottomsModel;
    public int ShoesModel;

    public void SetCustomizeState(CustomizePartsType type, int index)
    {
        switch (type)
        {
            case CustomizePartsType.TopsModel:
                this.TopsModel = index;
                break;
            case CustomizePartsType.BottomsModel:
                this.BottomsModel = index;
                break;
            case CustomizePartsType.ShoesModel:
                this.ShoesModel = index;
                break;
            default:
                break;
        }
    }
}
