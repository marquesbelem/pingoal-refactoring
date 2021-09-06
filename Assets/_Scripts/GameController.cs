using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	[SerializeField]
	private Arena _arena;
	[SerializeField]
	private Pallet _palletR;
	[SerializeField]
	private Pallet _palletL;
	[SerializeField]
	private Goalkeeper _goalkeeper;
	[SerializeField]
	private FormationData _formationData;

	private void Start()
	{
		SetupFormation();
	}

	private void SetupFormation()
	{
		_arena.Data = _formationData.ArenaData;
		_palletL.Data = _formationData.PalletRData;
		_palletR.Data = _formationData.PalletRData;
		_goalkeeper.Data = _formationData.GoalkeeperData;
	}
}
