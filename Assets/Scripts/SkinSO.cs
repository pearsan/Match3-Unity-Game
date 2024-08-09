using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinSO", menuName = "Scriptable Skin")]
public class SkinSO : ScriptableObject
{
    public SkinType skinType;

    public List<Sprite> spritesNormal;
    public List<Sprite> spritesFish;
}

public enum SkinType
{
    Normal,
    Fish
}