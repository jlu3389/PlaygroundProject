﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(AutoMove))]
public class AutoMoveInspector : BaseInspectorWindow
{
	private string explanation = "The gameObject moves automatically in a specific direction. Combine Horizontal and Vertical to create any direction.";

	public override void OnInspectorGUI()
	{
		GUILayout.Space(10);
		EditorGUILayout.HelpBox(explanation, MessageType.Info);

		base.OnInspectorGUI();
	}
}