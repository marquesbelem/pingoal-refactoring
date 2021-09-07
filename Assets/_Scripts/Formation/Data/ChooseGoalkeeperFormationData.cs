using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "GoalkeeperData", menuName = "Pingoal/Escolhas de Goleiros")]
public class ChooseGoalkeeperFormationData : ScriptableObject
{
	public List<GoalkeeperData> Goalkeepers;
	
	public void GetAll()
	{
		var allGoalkeepers = Resources.LoadAll<GoalkeeperData>("ScriptableObjects/Goleiros");
		Goalkeepers = allGoalkeepers.OfType<GoalkeeperData>().ToList();
	}

	public void ClearAll()
	{
		Goalkeepers.Clear();
	}
}
