using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class Loading : MonoBehaviour
{
	public static Loading Instance;
	
	[SerializeField]
	private float _delay;
	[SerializeField]
	private CanvasGroup _canvasGroup;
	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

		_canvasGroup = GetComponent<CanvasGroup>();
		_canvasGroup.alpha = 0;
		_canvasGroup.blocksRaycasts = false;
		DontDestroyOnLoad(gameObject);
	}

	public void Begin()
	{
		_canvasGroup.LeanAlpha(1, _delay);
	}

	public void End()
	{
		_canvasGroup.LeanAlpha(0, _delay);
	}
}
