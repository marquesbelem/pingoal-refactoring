using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ChooseArenasFormationData", menuName = "Pingoal/Escolhas de Arenas")]
public class ChooseArenaFormationData : ScriptableObject
{
	public List<ArenaData> Arenas;

	public void GetAll()
	{
		var allArenas = Resources.LoadAll<ArenaData>("ScriptableObjects/Arenas");
		Arenas = allArenas.OfType<ArenaData>().ToList();
	}

	public void ClearAll()
	{
		Arenas.Clear();
	}
}