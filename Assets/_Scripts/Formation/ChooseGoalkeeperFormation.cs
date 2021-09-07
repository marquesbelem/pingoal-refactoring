using UnityEngine;

public class ChooseGoalkeeperFormation: ChooseFormation
{
	[SerializeField]
	private GoalkeeperData _data;

	[SerializeField]
	private ChooseGoalkeeperFormationData _chooseData;

	public override void NextChoose()
	{
		base.NextChoose();

		_data = _chooseData.Goalkeepers[_indexChoose];
		
		SetDataFormationController();
	}

	public override void PreviousChoose()
	{
		base.PreviousChoose();

		_data = _chooseData.Goalkeepers[_indexChoose];

		SetDataFormationController();
	}

	public override void Start()
	{
		_data = _chooseData.Goalkeepers[_indexChoose];
		_indexMax = _chooseData.Goalkeepers.Count - 1;
		base.Start();
	}

	public override void SetDataFormationController()
	{
		FormationController.Instance.Data.GoalkeeperData = _data;
		base.SetDataFormationController();
	}
}