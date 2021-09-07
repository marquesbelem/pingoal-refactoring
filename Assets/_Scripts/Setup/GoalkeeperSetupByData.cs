using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class GoalkeeperSetupByData : MonoBehaviour
{
	[SerializeField]
	private GoalkeeperData _data;
	[SerializeField]
	private SpriteRenderer _skin;

	public GoalkeeperData Data
	{
		get => _data;
		set
		{
			if (value != _data)
			{
				_data = value;
				Setup();
			}
		}
	}

	private void Start()
	{
		_skin = GetComponent<SpriteRenderer>();
	}

	private void Setup()
	{
		_skin.sprite = _data.Skin;
	}
}