using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "FormationData", menuName = "Pingoal/Formação")]
public class FormationData : ScriptableObject
{
	private const string ARENA_KEY = "ARENA";
	private const string PALLET_L_KEY = "PALLET_L";
	private const string PALLET_R_KEY = "PALLET_R";
	private const string GOALKEEPER_KEY = "GOALKEEPER";

	[SerializeField]
	private ArenaData _ArenaData;
	[SerializeField]
	private PalletData _PalletLData;
	[SerializeField]
	private PalletData _PalletRData;
	[SerializeField]
	private GoalkeeperData _GoalkeeperData;

	public ArenaData ArenaData
	{
		get
		{
			if (PlayerPrefs.HasKey(ARENA_KEY))
			{
				_ArenaData = FindArenaData(PlayerPrefs.GetString(ARENA_KEY));
			}

			return _ArenaData;
		}
		set
		{
			if (value != _ArenaData)
			{
				_ArenaData = value;
				PlayerPrefs.SetString(ARENA_KEY, _ArenaData.ID);
			}
		}
	}

	public PalletData PalletLData
	{
		get
		{
			if (PlayerPrefs.HasKey(PALLET_L_KEY))
			{
				_PalletLData = FindPalletData(PlayerPrefs.GetString(PALLET_L_KEY));
			}

			return _PalletLData;
		}
		set
		{
			if (value != _PalletLData)
			{
				_PalletLData = value;
				PlayerPrefs.SetString(PALLET_L_KEY, _PalletLData.ID);
			}
		}
	}

	public PalletData PalletRData
	{
		get
		{
			if (PlayerPrefs.HasKey(PALLET_R_KEY))
			{
				_PalletRData = FindPalletData(PlayerPrefs.GetString(PALLET_R_KEY));
			}

			return _PalletRData;
		}
		set
		{
			if (value != _PalletRData)
			{
				_PalletRData = value;
				PlayerPrefs.SetString(PALLET_R_KEY, _PalletRData.ID);
			}
		}
	}

	public GoalkeeperData GoalkeeperData
	{
		get
		{
			if (PlayerPrefs.HasKey(GOALKEEPER_KEY))
			{
				_GoalkeeperData = FindGoalkeeperData(PlayerPrefs.GetString(GOALKEEPER_KEY));
			}

			return _GoalkeeperData;
		}
		set
		{
			if (value != _GoalkeeperData)
			{
				_GoalkeeperData = value;
				PlayerPrefs.SetString(GOALKEEPER_KEY, _GoalkeeperData.ID);
			}
		}
	}

	private ArenaData FindArenaData(string ID)
	{
		var allArena = Resources.LoadAll<ArenaData>("ScriptableObjects/Arenas");
		var allArenaList = allArena.OfType<ArenaData>().ToList();

		return allArenaList.First(arena => arena.ID == ID);
	}

	private PalletData FindPalletData(string ID)
	{
		var allPallet = Resources.LoadAll<PalletData>("ScriptableObjects/Palhetas");
		var allPalletList = allPallet.OfType<PalletData>().ToList();

		return allPalletList.First(pallet => pallet.ID == ID);
	}

	private GoalkeeperData FindGoalkeeperData(string ID)
	{
		var allGoalkeeper = Resources.LoadAll<GoalkeeperData>("ScriptableObjects/Goleiros");
		var allGoalkeeperList = allGoalkeeper.OfType<GoalkeeperData>().ToList();

		return allGoalkeeperList.First(pallet => pallet.ID == ID);
	}
}