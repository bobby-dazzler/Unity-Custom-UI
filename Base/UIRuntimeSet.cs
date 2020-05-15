using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

[CreateAssetMenu(menuName="UI/Runtime Sets/UI GameObjects")]
public class UIRuntimeSet : RuntimeSet<GameObject> {

	public GameObject activeUI;
	public int switchToUIIndex;

	public StateController controller;

	public void SetSwitchToUIIndex(int index) {
		switchToUIIndex = index;
	}

	public void SwitchToUIAtIndex(int index) {
/* 		if (activeUIIndex == index) {
			return;
		} */

		controller.CallCurrentStateActionAtIndex(2); // CloseMenuAct 
		switchToUIIndex = index;
		controller.UpdateState();
		controller.CallCurrentStateActionAtIndex(0); // OpenMenuAct
		controller.CallCurrentStateActionAtIndex(1); // ConfigureMenuAct
	}
}

