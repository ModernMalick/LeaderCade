using UnityEngine;

public class TargetPositionManager : MonoBehaviour
{
    [Header("MANAGERS")]
    [SerializeField] private InstanceManager instanceManager;

    [Header("X RANGE")] 
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    
    [Header("Y RANGE")] 
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    
    public void ChangePosition()
    {
        var newX = Random.Range(minX, maxX);
        var newY = Random.Range(minY, maxY);
        instanceManager.startPosition = new Vector3(newX, newY, 19f);
    }
}
