using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomUIText : CustomUI {

    public enum TextType {
        h1, h2, h3, p, button
    }
    public TextType textType;

    TextMeshProUGUI text;

    protected override void OnSkinUI() {
	    base.OnSkinUI();

        text = GetComponentInChildren<TextMeshProUGUI>();

        if (textType == TextType.h1) {
            text.font = skinData.defaultTextFont; 
            text.color = skinData.defaultTextColour;
        } else if (textType == TextType.h2) {

        } else if (textType == TextType.h3) {

        }  else if (textType == TextType.button) {
            text.font = skinData.defaultTextFont; 
            text.color = skinData.defaultTextColour;
        }

   }
}
