using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

public class UiInitializer : MonoBehaviour {

	public MainMenuUIState defaultState;

	public UIRuntimeSet allUIStateRootGameObjects;

	//public UIRuntimeSet menusAvaialbleFromGridGen;

	void Awake () {
		StateController controller = GetComponent<StateController>();
		controller.currentState = defaultState;
		allUIStateRootGameObjects.controller = controller;
		
		ConfigureMenus();
	}

	void ConfigureMenus () {
		
		allUIStateRootGameObjects.Clear();

		allUIStateRootGameObjects.Add(transform.Find("Canvas/Main Menu").gameObject);
		allUIStateRootGameObjects.Add(transform.Find("Canvas/Grid Generator UI").gameObject);

		for (int i = 1; i < allUIStateRootGameObjects.Count(); i++) {
			allUIStateRootGameObjects.items[i].SetActive(false);
		}
		
		allUIStateRootGameObjects.switchToUIIndex = int.MinValue;
		allUIStateRootGameObjects.items[0].SetActive(true);
		allUIStateRootGameObjects.activeUI = allUIStateRootGameObjects.items[0];
		
	}
}
