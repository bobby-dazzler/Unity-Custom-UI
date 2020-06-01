using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

[CreateAssetMenu(menuName="UI/Runtime Sets/UI GameObjects")]
public class UIRuntimeSet : RuntimeSet<GameObject> {

	public int activeUIIndex;
	//public int switchToUIIndex;

	public StateController controller;

	public void SwitchToUIAtIndex(int index) {
		if (activeUIIndex == index) {
			return;
		}

		items[activeUIIndex].SetActive(false);
		items[index].SetActive(true);
		activeUIIndex = index;
		controller.UpdateState();
	}
}

