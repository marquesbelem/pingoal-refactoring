using UnityEngine;

public class ChooseArenaFormation : ChooseFormation
{
	[SerializeField]
	private ArenaData _data;
	[SerializeField]
	private ChooseArenaFormationData _chooseData;

	public override void NextChoose()
	{
		base.NextChoose();

		_data = _chooseData.Arenas[_indexChoose];
		
		SetDataFormationController();
	}

	public override void PreviousChoose()
	{
		base.PreviousChoose();

		_data = _chooseData.Arenas[_indexChoose];

		SetDataFormationController();
	}

	public override void Start()
	{
		_data = _chooseData.Arenas[_indexChoose];
		_indexMax = _chooseData.Arenas.Count - 1;
		base.Start();
	}

	public override void SetDataFormationController()
	{
		FormationController.Instance.Data.ArenaData = _data;
		base.SetDataFormationController();
	}
}
