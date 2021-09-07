using UnityEngine;

public class ChoosePalletFormation : ChooseFormation
{
	[SerializeField]
	private PalletSide _side;

	[SerializeField]
	private PalletData _data;

	[SerializeField]
	private ChoosePalletFormationData _chooseData;

	public override void NextChoose()
	{
		base.NextChoose();

		_data = _chooseData.Pallets[_indexChoose];

		SetDataFormationController();
	}

	public override void PreviousChoose()
	{
		base.PreviousChoose();

		_data = _chooseData.Pallets[_indexChoose];

		SetDataFormationController();
	}

	public override void Start()
	{
		_data = _chooseData.Pallets[_indexChoose];
		_indexMax = _chooseData.Pallets.Count - 1;
		base.Start();
	}

	public override void SetDataFormationController()
	{
		if (_side == PalletSide.Left)
		{
			FormationController.Instance.Data.PalletLData = _data;
		}
		else
		{
			FormationController.Instance.Data.PalletRData = _data;
		}

		base.SetDataFormationController();
	}
}