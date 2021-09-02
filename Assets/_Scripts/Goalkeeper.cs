using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class Goalkeeper : MonoBehaviour
{
    private const string TAG_BALL = "Ball";

    [SerializeField]
    private GoalkeeperData _data;
    [SerializeField]
    private Transform _targetRight;
    [SerializeField]
    private Transform _targetLeft;
    [SerializeField]
    private float _speed = 10;

    private SpriteRenderer _skin;
    private GameObject _ball;
    private Rigidbody2D _rigidbody2D;

    private bool goToLeft = true;
    private bool goToRight;

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

    private void Setup()
    {
        _skin.sprite = _data.Skin;
    }

    private void Start()
    {
        _skin = GetComponent<SpriteRenderer>();
        _ball = GameObject.FindGameObjectWithTag(TAG_BALL);
        _rigidbody2D = GetComponent<Rigidbody2D>();

        Setup();
    }

    private void FixedUpdate()
    {
        //MoveByTarget();
        MoveByBall();
    }

    private void MoveByBall()
    {
        Vector2 direction = Vector2.zero;
        direction = _ball.transform.position - transform.position;

        _rigidbody2D.AddRelativeForce(direction.normalized * _speed, ForceMode2D.Force);
    }

    private void MoveByTarget()
    {
        Vector2 direction = Vector2.zero;

        if (goToLeft)
        {
            if (Vector3.Distance(transform.position, _targetLeft.position) > 1f)
            {
                direction = _targetLeft.position - transform.position;
            }
            else
            {
                goToLeft = false;
                goToRight = true;
            }
        }

        if (goToRight)
        {
            if (Vector3.Distance(transform.position, _targetRight.position) > 1f)
            {
                direction = _targetRight.position - transform.position;
            }
            else
            {
                goToRight = false;
                goToLeft = true;
            }
        }

        _rigidbody2D.AddRelativeForce(direction.normalized * _speed, ForceMode2D.Force);
    }
}