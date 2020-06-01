using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

[CreateAssetMenu(menuName="UI/Decisions/UI State Transition")]
public class UIGroupStateTransition : StateDecision {
   
    public UIRuntimeSet uiGroup;

    public int uiIndex;

    public override bool Decide (StateController controller) {
        if (uiGroup.activeUIIndex == uiIndex) {
            return true;
        } else {
            return false;
        }
    }
}
