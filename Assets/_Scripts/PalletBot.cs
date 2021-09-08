using UnityEngine;

[RequireComponent(typeof(Pallet))]
public class PalletBot : MonoBehaviour
{
	private Pallet _pallet;

	private void Awake()
	{
		_pallet = GetComponent<Pallet>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(TagsHelper.TAG_BALL))
		{
			_pallet.Move();
		}
	}
}