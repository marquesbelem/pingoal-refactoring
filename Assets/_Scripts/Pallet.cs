using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PalletSetupByData))]
public class Pallet : MonoBehaviour
{
	[SerializeField]
	private PalletSide _side;
	[SerializeField]
	private float _impulse = 100;

	private Rigidbody2D _rigidbody2D;
	private PalletSetupByData _setup; 

	public void Move()
	{
		_rigidbody2D.AddForce(transform.up * _impulse, ForceMode2D.Impulse);
	}

	private void Start()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
}
