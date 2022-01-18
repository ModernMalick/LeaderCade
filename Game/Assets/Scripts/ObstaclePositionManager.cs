using Objects.Ball;
using UnityEngine;

public class ObstaclePositionManager : MonoBehaviour
{
    [Header("VARIABLES")] [SerializeField] private float initialSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float levelCap;

    [Header("X RANGE")] [SerializeField] private float maxX;

    [SerializeField] private float minX;
    private Vector3 _currentPosition;

    private bool _goingRight = true;
    private float _speed;
    private float _targetX;

    private void Start()
    {
        BallCollisionManager.OnScoring += UpdateSpeed;
        _speed = initialSpeed;
    }

    private void Update()
    {
        ReachedTarget();
        _targetX = _goingRight ? maxX : minX;
        MoveObstacle();
    }

    private void MoveObstacle()
    {
        _currentPosition = gameObject.transform.position;
        var targetPosition = new Vector3(_targetX, _currentPosition.y, _currentPosition.z);
        var newPosition = Vector3.MoveTowards(_currentPosition, targetPosition, _speed * Time.deltaTime);
        gameObject.transform.position = newPosition;
    }

    private void ReachedTarget()
    {
        if (_currentPosition.x.Equals(maxX))
            _goingRight = false;
        else if (_currentPosition.x.Equals(minX)) _goingRight = true;
    }

    private void UpdateSpeed()
    {
        if (_speed >= maxSpeed) return;
        _speed += (maxSpeed - initialSpeed) / levelCap;
    }
}