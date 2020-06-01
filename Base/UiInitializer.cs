using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;
using UnityEngine.UI;

public class UiInitializer : MonoBehaviour {

	//public MainMenuUIState defaultState;

	public UIRuntimeSet gridEditorTabsGroup;

	public List<GameObject> gridEditorTabsObjects;

	public StateController inputHandlerStateController;

	void Awake () {
		ConfigureMenus();
	}

	void ConfigureMenus () {
		
		gridEditorTabsGroup.Clear();

		// gridEditorTabsGroup.Add(transform.Find("UI Controller/Canvas/Left Panel (Image)/Layout Group (Transform)/Grid Editor Tools (Image)").gameObject);
		// gridEditorTabsGroup.Add(transform.Find("UI Controller/Canvas/Left Panel (Image)/Layout Group (Transform)/Grid Manager Tools (Image)").gameObject);
		
		for (int i = 0; i < gridEditorTabsObjects.Count; i++) {
			gridEditorTabsGroup.Add(gridEditorTabsObjects[i]);
		}
		for (int i = 1; i < gridEditorTabsGroup.Count(); i++) {
			gridEditorTabsGroup.items[i].SetActive(false);
		}
		
		//gridEditorTabsGroup.switchToUIIndex = int.MinValue;
		//gridEditorTabsGroup.items[0].SetActive(true);
		//gridEditorTabsGroup.activeUI = gridEditorTabsGroup.items[0];
		gridEditorTabsGroup.controller = inputHandlerStateController;
		gridEditorTabsGroup.SwitchToUIAtIndex(0);
		
	}
}
