using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PalletSetupByData : MonoBehaviour
{
	[SerializeField]
	private PalletData _data;
	[SerializeField]
	private SpriteRenderer _skin;

	public PalletData Data
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
		_skin.sprite = _data.Skin;
	}
}