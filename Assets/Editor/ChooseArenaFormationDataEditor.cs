using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChooseArenaFormationData))]
public class ChooseArenaFormationDataEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		var script = (ChooseArenaFormationData)target;

		EditorGUILayout.Space(10);
		if (GUILayout.Button("CARREGAR TODAS AS ARENAS NA LISTA", GUILayout.Height(20)))
		{
			script.GetAll();
		}

		if (GUILayout.Button("LIMPAR AS ARENAS DA LISTA", GUILayout.Height(20)))
		{
			script.ClearAll();
		}
	}
}
