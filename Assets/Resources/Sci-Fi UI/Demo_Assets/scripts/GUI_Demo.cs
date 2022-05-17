﻿// Copyright (c) 2012-2022 FuryLion Group. All Rights Reserved.

using UnityEngine;

public class GUI_Demo : MonoBehaviour
{
	public GUISkin guiSkin;


	private Rect windowRect = new Rect(0, 0, 400, 380);
	private bool toggleTxt;
	private string stringToEdit = "Text Label";
	private string textToEdit = "TextBox:\nHello World\nI've got few lines...";
	private float hSliderValue;
	private float vSliderValue;
	private float hSbarValue;
	private float vSbarValue;
	private Vector2 scrollPosition = Vector2.zero;


	private void Start()
	{
		windowRect.x = (Screen.width - windowRect.width) / 2;
		windowRect.y = (Screen.height - windowRect.height) / 2;
	}


	private void OnGUI()
	{
		GUI.skin = guiSkin;
		windowRect = GUI.Window(0, windowRect, DoMyWindow, "My Window");
	}


	private void DoMyWindow(int windowID)
	{
		GUI.Box(new Rect(10, 50, 120, 250), "Box title");
		GUI.Button(new Rect(20, 80, 100, 20), "BUTTON");
		GUI.Label(new Rect(20, 115, 100, 20), "LABEL: Hello!");
		stringToEdit = GUI.TextField(new Rect(15, 140, 110, 20), stringToEdit, 25);
		hSliderValue = GUI.HorizontalSlider(new Rect(15, 175, 110, 30), hSliderValue, 0.0f, 10.0f);

		vSliderValue = GUI.VerticalSlider(new Rect(140, 50, 20, 200), vSliderValue, 100.0f, 0.0f);


		toggleTxt = GUI.Toggle(new Rect(165, 50, 100, 30), toggleTxt, "A Toggle text");
		textToEdit = GUI.TextArea(new Rect(165, 90, 185, 100), textToEdit, 200);

		GUI.Label(new Rect(180, 215, 100, 20), "ScrollView");
		scrollPosition = GUI.BeginScrollView(new Rect(180, 235, 160, 100), scrollPosition, new Rect(0, 0, 220, 200));
		GUI.Button(new Rect(0, 10, 100, 20), "Top-left");
		GUI.Button(new Rect(120, 10, 100, 20), "Top-right");
		GUI.Button(new Rect(0, 170, 100, 20), "Bottom-left");
		GUI.Button(new Rect(120, 170, 100, 20), "Bottom-right");
		GUI.EndScrollView();


		hSbarValue = GUI.HorizontalScrollbar(new Rect(10, 360, 360, 30), hSbarValue, 5.0f, 0.0f, 10.0f);
		vSbarValue = GUI.VerticalScrollbar(new Rect(380, 25, 30, 300), vSbarValue, 1.0f, 30.0f, 0.0f);


		GUI.DragWindow(new Rect(0, 0, 10000, 10000));
	}
}