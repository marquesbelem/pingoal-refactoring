using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class Pallet : MonoBehaviour
{
    [SerializeField]
    private PalletData _data;
    [SerializeField]
    private PalletSide _side;
    [SerializeField]
    private float _impulse = 100;

    private SpriteRenderer _skin;
    private Rigidbody2D _rigidbody2D;

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

    public void Move()
    {
        _rigidbody2D.AddForce(transform.up * _impulse, ForceMode2D.Impulse);
    }

    private void Setup()
    {
        _skin.sprite = _data.Skin;
    }

    private void Start()
    {
        _skin = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();

        Setup();
    }
}
