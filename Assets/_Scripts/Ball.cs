using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
	private Rigidbody2D _rigidbody2D;

	public void Move(float impulse)
	{
		_rigidbody2D.AddForce(new Vector2(transform.position.x, -transform.position.y) * impulse);
	}

	public void MoveToGoal(float impulse)
	{
		float positionX = Random.Range(-0.3f, 1f);
		_rigidbody2D.AddForce(new Vector2(positionX, -transform.position.y) * impulse * 2F);
	}

	public void MoveToRight(float impulse)
	{
		_rigidbody2D.AddForce(new Vector2(2f, -transform.position.y) * impulse);
	}

	public void MoveToLeft(float impulse)
	{
		_rigidbody2D.AddForce(new Vector2(-2f, -transform.position.y) * impulse);
	}

	public void ResetPosition(Transform target)
	{
		transform.position = target.position;
	}

	private void Start()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}
}
