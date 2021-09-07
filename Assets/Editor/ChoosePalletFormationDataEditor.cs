using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChoosePalletFormationData))]
public class ChoosePalletFormationDataEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		var script = (ChoosePalletFormationData)target;

		EditorGUILayout.Space(10);
		if (GUILayout.Button("CARREGAR TODAS AS PALHETAS NA LISTA", GUILayout.Height(20)))
		{
			script.GetAll();
		}

		if (GUILayout.Button("LIMPAR AS PALHETAS DA LISTA", GUILayout.Height(20)))
		{
			script.ClearAll();
		}
	}
}
