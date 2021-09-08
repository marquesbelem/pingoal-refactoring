using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public static GameController Instance;

	public int ScorePlayer1 = 0;
	public int ScorePlayer2 = 0;

	public Transform TargetByPlayer1;
	public Transform TargetByPlayer2;

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
	}
}
