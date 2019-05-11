using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;
using UnityEngine.UI;

public class UiInitializer : MonoBehaviour {

	public MainMenuUIState defaultState;

	public UIRuntimeSet allUIStateRootGameObjects;

	public WaveDataRuntimeSet allWaveData;

	public Transform waveAParent;

	public Transform waveBParent;

	public Transform waveCParent;

	void Awake () {
/* 		StateController controller = GetComponent<StateController>();
		controller.currentState = defaultState;
		allUIStateRootGameObjects.controller = controller;
		
		ConfigureMenus(); */

		ConfigureWaveData();
		SetWaveSliderValues();
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

	void ConfigureWaveData() {
		allWaveData.items[0].waveXSlider = waveAParent.Find("X Slider").GetComponent<Slider>();
		allWaveData.items[0].waveYSlider = waveAParent.Find("Y Slider").GetComponent<Slider>();
		allWaveData.items[0].waveSteepnessSlider = waveAParent.Find("Wave Height Slider").GetComponent<Slider>();
		allWaveData.items[0].waveLengthSlider = waveAParent.Find("Wave Length Slider").GetComponent<Slider>();
		
		allWaveData.items[1].waveXSlider = waveBParent.Find("X Slider").GetComponent<Slider>();
		allWaveData.items[1].waveYSlider = waveBParent.Find("Y Slider").GetComponent<Slider>();
		allWaveData.items[1].waveSteepnessSlider = waveBParent.Find("Wave Height Slider").GetComponent<Slider>();
		allWaveData.items[1].waveLengthSlider = waveBParent.Find("Wave Length Slider").GetComponent<Slider>();

		allWaveData.items[2].waveXSlider = waveCParent.Find("X Slider").GetComponent<Slider>();
		allWaveData.items[2].waveYSlider = waveCParent.Find("Y Slider").GetComponent<Slider>();
		allWaveData.items[2].waveSteepnessSlider = waveCParent.Find("Wave Height Slider").GetComponent<Slider>();
		allWaveData.items[2].waveLengthSlider = waveCParent.Find("Wave Length Slider").GetComponent<Slider>();
	}

	public void SetWaveSliderValues(){

		// Set the slider to the current values
		allWaveData.items[0].waveXSlider.value = allWaveData.items[0].wave.x;
		allWaveData.items[0].waveYSlider.value = allWaveData.items[0].wave.y;
		allWaveData.items[0].waveSteepnessSlider.value = allWaveData.items[0].wave.z;
		allWaveData.items[0].waveLengthSlider.value = allWaveData.items[0].wave.w;

		allWaveData.items[1].waveXSlider.value = allWaveData.items[1].wave.x;
		allWaveData.items[1].waveYSlider.value = allWaveData.items[1].wave.y;
		allWaveData.items[1].waveSteepnessSlider.value = allWaveData.items[1].wave.z;
		allWaveData.items[1].waveLengthSlider.value = allWaveData.items[1].wave.w;

		allWaveData.items[2].waveXSlider.value = allWaveData.items[2].wave.x;
		allWaveData.items[2].waveYSlider.value = allWaveData.items[2].wave.y;
		allWaveData.items[2].waveSteepnessSlider.value = allWaveData.items[2].wave.z;
		allWaveData.items[2].waveLengthSlider.value = allWaveData.items[2].wave.w; 

	}
}
