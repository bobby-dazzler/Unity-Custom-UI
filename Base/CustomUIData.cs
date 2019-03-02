using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(menuName = "Custom UI/Custom UI Data")]
public class CustomUIData : ScriptableObject {

    public Sprite buttonSprite;

    public SpriteState buttonSpriteState;

    public TMP_FontAsset defaultTextFont;
    public Color defaultTextColour;
}
