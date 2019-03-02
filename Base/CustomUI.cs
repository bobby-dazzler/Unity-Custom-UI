using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()]
public class CustomUI : MonoBehaviour {

	public CustomUIData skinData;

    protected virtual void OnSkinUI() {

    }

    public virtual void Awake () {
        OnSkinUI();
    }

    public virtual void Update() {
        // Write a custom editor for this to prevent this check running all the time
        if (Application.isEditor) {
            OnSkinUI();
        }
    }
}
