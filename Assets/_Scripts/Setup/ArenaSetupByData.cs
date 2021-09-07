using UnityEngine;

public class ArenaSetupByData : MonoBehaviour
{
	[SerializeField]
	private ArenaData _data;
	[SerializeField]
	private SpriteRenderer _mask;
	[SerializeField]
	private SpriteRenderer _background;

	public ArenaData Data
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

	private void Setup()
	{
		_mask.sprite = _data.Mask;
		_background.sprite = _data.Background;
	}
}