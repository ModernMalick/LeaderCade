using UnityEngine;

public class ObstaclePositionManager : MonoBehaviour
{
    [SerializeField] private new GameObject gameObject;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }
}
