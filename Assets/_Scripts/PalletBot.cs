using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Pallet))]
public class PalletBot : MonoBehaviour
{
	private Pallet _pallet;
	[SerializeField]
	private float _repeatRate = 10f;
	[SerializeField]
	private float _timer = 1f;

	private void Awake()
	{
		_pallet = GetComponent<Pallet>();
	}

	private void Start()
	{
		//InvokeRepeating("InvokeMove", _timer, _repeatRate * 0.5f);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(TagsHelper.TAG_BALL))
		{
			Move();
		}
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(TagsHelper.TAG_BALL))
		{
			Move();
		}
	}

	private void Move()
	{
		_pallet.Move();
	}

	private void InvokeMove()
	{
		var time = _repeatRate; 

		while (time >= 0)
		{
			time -= Time.deltaTime;
			Move();
		}
	}
}