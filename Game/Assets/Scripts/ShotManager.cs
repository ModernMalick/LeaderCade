using System;
using Objects.Ball;
using UnityEngine;

public class ShotManager : MonoBehaviour
{
    [Header("MANAGERS")] [SerializeField] private InstanceManager ballManager;

    [SerializeField] private InstanceManager targetManager;

    [Header("VARIABLES")] [SerializeField] private float speed;

    private GameObject _ball;
    private Vector3 _ballPosition;
    private Rigidbody _ballRigidbody;

    private string _gameObjectTouchedName;

    private InputManager _inputManager;

    private GameObject _target;
    private string _targetName;
    private Vector3 _targetPosition;

    private void Start()
    {
        _inputManager = InputManager.Instance;
        BallCollisionManager.OnScoring += ResetShot;
        LossManager.Loss += ResetShot;
    }

    private void Update()
    {
        CheckTarget();
        if (!TouchedTarget()) return;
        CheckBall();
    }

    private void FixedUpdate()
    {
        MoveBall();
    }

    private void OnDestroy()
    {
        BallCollisionManager.OnScoring -= ResetShot;
        LossManager.Loss -= ResetShot;
    }

    private void ResetShot()
    {
        Destroy(_ball);
        Destroy(_target);
    }

    private void MoveBall()
    {
        if (_ball == null) return;
        _ballPosition = Vector3.MoveTowards(_ballPosition, _targetPosition, speed * Time.deltaTime);
        _ballRigidbody.MovePosition(_ballPosition);
    }

    private bool TouchedTarget()
    {
        if (_inputManager.gameObjectTouched == null) return false;
        _gameObjectTouchedName = _inputManager.gameObjectTouched.name;
        return _targetName == _gameObjectTouchedName;
    }

    private void CheckTarget()
    {
        if (targetManager.CurrentGameObject == null) return;
        _target = targetManager.CurrentGameObject;
        _targetName = _target.name;
        _targetPosition = _target.transform.position;
    }

    private void CheckBall()
    {
        if (ballManager.CurrentGameObject == null) return;
        _ball = ballManager.CurrentGameObject;
        _ballPosition = _ball.transform.position;
        _ballRigidbody = _ball.GetComponent<Rigidbody>();
    }
}