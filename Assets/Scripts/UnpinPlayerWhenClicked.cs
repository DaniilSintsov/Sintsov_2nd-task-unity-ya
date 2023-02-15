using UnityEngine;

public class UnpinPlayerWhenClicked : MonoBehaviour
{
    private HingeJoint2D _hingeJoint2d;

    private void Start()
    {
        _hingeJoint2d = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _hingeJoint2d.enabled = false;
        }
    }
}
