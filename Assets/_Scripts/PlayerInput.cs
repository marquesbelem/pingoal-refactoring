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
			if (Input.GetKey(KeyCode.A))
			{
				_pallet.Move();
			}
		}
		else
		{
			if (Input.GetKey(KeyCode.D))
			{
				_pallet.Move();
			}
		}
	}
}
