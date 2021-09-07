using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChooseGoalkeeperFormationData))]
public class ChooseGoalkeeperFormationDataEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		var script = (ChooseGoalkeeperFormationData)target;

		EditorGUILayout.Space(10);
		if (GUILayout.Button("CARREGAR TODAS OS GOLEIROS NA LISTA", GUILayout.Height(20)))
		{
			script.GetAll();
		}

		if (GUILayout.Button("LIMPAR OS GOLEIROS DA LISTA", GUILayout.Height(20)))
		{
			script.ClearAll();
		}
	}
}
