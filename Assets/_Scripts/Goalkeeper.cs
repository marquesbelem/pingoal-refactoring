﻿using UnityEngine;

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
    [SerializeField]
    private float _impulse = 100;

    private SpriteRenderer _skin;
    private Ball _ball;
    private Rigidbody2D _rigidbody2D;

    private bool _goToLeft = true;
    private bool _goToRight;

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
        _ball = GameObject.FindGameObjectWithTag(TAG_BALL).GetComponent<Ball>();
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
        _rigidbody2D.AddForce(new Vector2(_ball.transform.position.x, transform.position.y) * _speed);
    }

    private void MoveByTarget()
    {
        Vector2 direction = Vector2.zero;

        if (_goToLeft)
        {
            if (Vector3.Distance(transform.position, _targetLeft.position) > 1f)
            {
                direction = _targetLeft.position - transform.position;
            }
            else
            {
                _goToLeft = false;
                _goToRight = true;
            }
        }

        if (_goToRight)
        {
            if (Vector3.Distance(transform.position, _targetRight.position) > 1f)
            {
                direction = _targetRight.position - transform.position;
            }
            else
            {
                _goToRight = false;
                _goToLeft = true;
            }
        }

        _rigidbody2D.AddRelativeForce(direction.normalized * _speed, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TAG_BALL))
        {
            ImpulseBall();
        }
    }

    private void ImpulseBall()
    {
        switch (_data.Power)
        {
            case GoalkeeperType.Classic:
                _ball.Move(_impulse);
                break;
            case GoalkeeperType.Attack:
                _ball.MoveToGoal(_impulse);
                break;
            case GoalkeeperType.Left:
                _ball.MoveToLeft(_impulse);
                break;
            case GoalkeeperType.Right:
                _ball.MoveToRight(_impulse);
                break;
            default:
                _ball.Move(_impulse);
                break;
        }
    }
}
