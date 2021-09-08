using System.Collections;
using UnityEngine;

public class MarkGoal : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag(TagsHelper.TAG_BALL))
		{
			var ball = collision.gameObject.GetComponent<Ball>();

			if (gameObject.CompareTag(TagsHelper.TAG_GOAL_PLAYER_1))
			{
				GameController.Instance.ScorePlayer1++;
				ball.ResetPosition(GameController.Instance.TargetByPlayer1);
			}
			else if (gameObject.CompareTag(TagsHelper.TAG_GOAL_PLAYER_2))
			{
				GameController.Instance.ScorePlayer2++;
				ball.ResetPosition(GameController.Instance.TargetByPlayer2);
			}
		}
	}
}
