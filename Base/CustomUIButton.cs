﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class CustomUIButton : CustomUI {

	Image image;
	Button button;

	protected override void OnSkinUI() {
		base.OnSkinUI();

		image = GetComponent<Image>();
		button = GetComponent<Button>();

		button.transition = Selectable.Transition.SpriteSwap;
		button.targetGraphic = image;

		image.sprite = skinData.buttonSprite;
		image.type = Image.Type.Sliced;
		button.spriteState = skinData.buttonSpriteState;
	}
}
