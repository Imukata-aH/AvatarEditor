using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CustomizePartsCategory
{
    TopsModel,
    BottomsModel,
    ShoesModel,
}

[System.Serializable]
public class AvatarCustomizeStatus
{
    public uint TopsModel;
    public uint BottomsModel;
    public uint ShoesModel;

    public void SetCustomizeState(CustomizePartsCategory type, uint index)
    {
        switch (type)
        {
            case CustomizePartsCategory.TopsModel:
                this.TopsModel = index;
                break;
            case CustomizePartsCategory.BottomsModel:
                this.BottomsModel = index;
                break;
            case CustomizePartsCategory.ShoesModel:
                this.ShoesModel = index;
                break;
            default:
                break;
        }
    }

    public uint GetCustomizeState(CustomizePartsCategory type)
    {
        switch (type)
        {
            case CustomizePartsCategory.TopsModel:
                return this.TopsModel;
            case CustomizePartsCategory.BottomsModel:
                return this.BottomsModel;
            case CustomizePartsCategory.ShoesModel:
                return this.ShoesModel;
            default:
                return 0;
        }
    }
}
