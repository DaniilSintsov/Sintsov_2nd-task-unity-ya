using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothSpeed = 0.125f;
    [SerializeField] private Vector3 _offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = _target.position + _offset;
        var position = transform.position;
        Vector3 smoothedPosition = Vector3.Lerp(position, desiredPosition, _smoothSpeed);
        position = new Vector3(smoothedPosition.x, smoothedPosition.y, position.z);
        transform.position = position;
    }
}
