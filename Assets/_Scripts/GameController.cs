using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public static GameController Instance;
	public int ScorePlayer1
	{
		get { return _scorePlayer1; }
		set
		{
			_scorePlayer1 = value;
			_updateTextScorePlayer1?.Invoke();
		}
	}

	public int ScorePlayer2
	{
		get { return _scorePlayer2; }
		set
		{
			_scorePlayer2 = value;
			_updateTextScorePlayer2?.Invoke();
		}
	}

	public Transform TargetByPlayer1;
	public Transform TargetByPlayer2;

	[SerializeField]
	private Text _textScorePlayer1;
	[SerializeField]
	private Text _textScorePlayer2;

	private Action _updateTextScorePlayer1;
	private Action _updateTextScorePlayer2;

	[SerializeField]
	private int _scorePlayer1;
	[SerializeField]
	private int _scorePlayer2;
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void Start()
	{
		_updateTextScorePlayer1 += SetTextScorePlayer1;
		_updateTextScorePlayer2 += SetTextScorePlayer2;
	}

	private void SetTextScorePlayer1()
	{
		_textScorePlayer1.text = _scorePlayer1.ToString();
	}

	private void SetTextScorePlayer2()
	{
		_textScorePlayer2.text = _scorePlayer2.ToString();
	}

	public void Menu()
	{
		SceneManagerHelper.Instance.LoadSceneMenu();
	}
}
