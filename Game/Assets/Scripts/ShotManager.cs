using Elements.Ball;
using UnityEngine;

public class ShotManager : MonoBehaviour
{
    [Header("MANAGERS")]
    [SerializeField] private InputManager inputManager;
    [SerializeField] private InstanceManager ballManager;
    [SerializeField] private InstanceManager targetManager;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TargetPositionManager targetPositionManager;
    
    [Header("VARIABLES")]
    [SerializeField] private float speed;
    
    private GameObject _target;
    private string _targetName;
    private Vector3 _targetPosition;
    
    private string _gameObjectTouchedName;
    
    private GameObject _ball;
    private Vector3 _ballPosition;
    private Rigidbody _ballRigidbody;
    private BallCollisionManager _ballCollisionManager;
    
    private bool _touching;

    private void Update()
    {
        CheckTarget();
        if(!TouchedTarget()) return;
        CheckBall();
        MoveBall();
        if (!_touching) return;
        ResetShot();
    }

    private void ResetShot()
    {
        Destroy(_ball);
        Destroy(_target);
        inputManager.touched = false;
        scoreManager.Scorer();
        targetPositionManager.ChangePosition();
        _ballCollisionManager.scored = false;
    }

    private void MoveBall()
    {
        if(_ball == null) return;
        _ballPosition =  Vector3.MoveTowards (_ballPosition, _targetPosition, speed * Time.fixedDeltaTime);
        _ballRigidbody.MovePosition(_ballPosition);
        _touching = _ballCollisionManager.scored;
    }

    private bool TouchedTarget()
    {
        if (inputManager.gameObjectTouched == null) return false;
        _gameObjectTouchedName = inputManager.gameObjectTouched.name;
        return _targetName == _gameObjectTouchedName;
    }

    private void CheckTarget()
    {
        if(targetManager.CurrentGameObject == null) return;
        _target = targetManager.CurrentGameObject;
        _targetName = _target.name;
        _targetPosition = _target.transform.position;
    }

    private void CheckBall()
    {
        if(ballManager.CurrentGameObject == null) return;
        _ball = ballManager.CurrentGameObject;
        _ballPosition = _ball.transform.position;
        _ballRigidbody = _ball.GetComponent<Rigidbody>();
        _ballCollisionManager = _ball.GetComponent<BallCollisionManager>();
    }
}
