using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;
using UnityEngine.UI;
using Unity3DTileGrid;
using UnityUserInput;

public class UiInitializer : MonoBehaviour {

	//public MainMenuUIState defaultState;

	[Header("Grid Editor")]
	public UIRuntimeSet gridEditorTabsGroup;

	public List<GameObject> gridEditorTabsObjects;

	public StateController inputHandlerStateController;

	public GridData gridData;

	public Transform uiContentTogglesParent;

	public GridContentFactory tileContentFactory;

	public GridContentFactory chunkContentFactory;

	[Header("Voronoi")]
	public UIRuntimeSet voronoiUISet;
	public List<GameObject> voronoiUIObjects;

	[Header("Toggles")]

	public Transform uiTogglePrefab;

	public Transform uiToggleParent;

	public CreateGridContentAct createGridContentAct;

	public InputField posisionXInputField; // assigned by UIinitializer, scrap these when creating proper UI
	public InputField posisionYInputField;
	public InputField posisionZInputField;
	public InputField scaleXInputField;
	public InputField scaleYInputField;
	public InputField scaleZInputField;

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

		createGridContentAct.posisionXInputField = posisionXInputField;
		createGridContentAct.posisionYInputField = posisionYInputField;
		createGridContentAct.posisionZInputField = posisionZInputField;
		createGridContentAct.scaleXInputField = scaleXInputField;
		createGridContentAct.scaleYInputField = scaleYInputField;
		createGridContentAct.scaleZInputField = scaleZInputField;
		createGridContentAct.posisionXInputField.text = "0";
		createGridContentAct.posisionYInputField.text = "0";
		createGridContentAct.posisionZInputField.text = "0";
		createGridContentAct.scaleXInputField.text = "0";
		createGridContentAct.scaleXInputField.text = "0";
		createGridContentAct.scaleXInputField.text = "0";
		createGridContentAct.UpdatePositionOffset();
		createGridContentAct.UpdateScale();
	}

	public void CreateUIToggles (int mode) {
		foreach (Transform child in uiToggleParent) {
			Destroy(child.gameObject);
		}

		ToggleGroup tg = uiToggleParent.GetComponent<ToggleGroup>();
		GridContentFactory factory = tileContentFactory;
		if (mode == 0) {
			factory = tileContentFactory;
			createGridContentAct.parentMode = CreateGridContentAct.ParentMode.Tile;
		} else if (mode == 1) {
			factory = chunkContentFactory;
			createGridContentAct.parentMode = CreateGridContentAct.ParentMode.Chunk;
		}

		

		for (int i = 0; i < factory.items.Count; i++) {
			Transform t = Instantiate(uiTogglePrefab);
			//t.name = factory.items.contentType.contentName;
			t.SetParent(uiToggleParent);
			Toggle toggle = t.GetComponent<Toggle>();
			if (i != 0) {
				toggle.isOn = false;
			}
			toggle.group = tg;
			int index = i;
			toggle.onValueChanged.AddListener ( (isSeleted) => { createGridContentAct.ChangeActiveContentId(index); });
		}
	}
}
