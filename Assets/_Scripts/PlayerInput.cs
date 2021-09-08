using UnityEngine;

[RequireComponent(typeof(Pallet))]
public class PlayerInput : MonoBehaviour
{
	private Pallet _pallet;
	
	private void Awake()
	{
		_pallet = GetComponent<Pallet>();
	}

	private void Update()
	{
		// TODO : Change input for new input system. 

		if (_pallet.Side == PalletSide.Left)
		{
			if (Input.GetKeyDown(KeyCode.A))
			{
				_pallet.Move();
			}
		}
		else
		{
			if (Input.GetKeyDown(KeyCode.D))
			{
				_pallet.Move();
			}
		}
	}
}
