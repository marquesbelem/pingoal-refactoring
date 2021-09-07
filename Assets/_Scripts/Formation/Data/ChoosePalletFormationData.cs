using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ChoosePalletFormationData", menuName = "Pingoal/Escolhas de Palhetas")]
public class ChoosePalletFormationData : ScriptableObject
{
	public List<PalletData> Pallets;

	public void GetAll()
	{
		var allPallets = Resources.LoadAll<PalletData>("ScriptableObjects/Palhetas");
		Pallets = allPallets.OfType<PalletData>().ToList();
	}

	public void ClearAll()
	{
		Pallets.Clear();
	}
}
