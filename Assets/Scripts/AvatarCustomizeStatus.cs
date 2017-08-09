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
    public int TopsModel;
    public int BottomsModel;
    public int ShoesModel;

    public void SetCustomizeState(CustomizePartsCategory type, int index)
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
}
