using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CustomizePartsType
{
    TopsModel,
    TopsMaterial,
    BottomsModel,
    BottomsMaterial,
    ShoesModel,
    ShoesMaterial,
    HairModel,
    HairColor,
    EyeTexture,
    SkinColor,
}

[System.Serializable]
public class AvatarCustomizeStatus
{
    public int TopsModel;
    public int TopsMaterial;
    public int BottomsModel;
    public int BottomsMaterial;
    public int ShoesModel;
    public int ShoesMaterial;
    public int HairModel;
    public Color HairColor;
    public int EyeTexture;
    public Color SkinColor;

    public void SetCustomizeState(CustomizePartsType type, int index)
    {
        switch (type)
        {
            case CustomizePartsType.TopsModel:
                this.TopsModel = index;
                break;
            case CustomizePartsType.TopsMaterial:
                this.TopsMaterial = index;
                break;
            case CustomizePartsType.BottomsModel:
                this.BottomsModel = index;
                break;
            case CustomizePartsType.BottomsMaterial:
                this.BottomsMaterial = index;
                break;
            case CustomizePartsType.ShoesModel:
                this.ShoesModel = index;
                break;
            case CustomizePartsType.ShoesMaterial:
                this.ShoesMaterial = index;
                break;
            case CustomizePartsType.HairModel:
                this.HairModel = index;
                break;
            case CustomizePartsType.EyeTexture:
                this.EyeTexture = index;
                break;
            default:
                break;
        }
    }

    public void SetCustomizeState(CustomizePartsType type, Color color)
    {
        switch (type)
        {
            case CustomizePartsType.HairColor:
                this.HairColor = color;
                break;
            case CustomizePartsType.SkinColor:
                this.SkinColor = color;
                break;
            default:
                break;
        }
    }
}
