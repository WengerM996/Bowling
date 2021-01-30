using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallLauncher : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Vector3 _direction;
    private Rigidbody _rigidBody;
    private bool _isBallLaunched;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        Debug.LogWarning("Click to launch ball");
    }

    private void Update()
    {
        if (_isBallLaunched) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            _isBallLaunched = true;
            Launch();
        }
    }

    private void Launch()
    {
        _rigidBody.AddForce(_direction * _force, ForceMode.Impulse);
    }
}
