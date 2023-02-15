using UnityEngine;

public class RockPlayer : MonoBehaviour
{
    private Rigidbody2D _rigidbody2d;
    [SerializeField] private float _thrust = 100.0f;

    private void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _rigidbody2d.AddForce(transform.right * _thrust);
    }
}
