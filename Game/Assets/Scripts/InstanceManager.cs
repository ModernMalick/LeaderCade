using UnityEngine;

public class InstanceManager : MonoBehaviour
{
    [SerializeField] private GameObject myGameObject;
    [SerializeField] private new string name;
    [SerializeField] public Vector3 startPosition;

    private int _id;

    public GameObject CurrentGameObject { get; private set; }

    private void Start()
    {
        _id = 0;
        NewGameObject();
    }

    private void Update()
    {
        CheckGameObject();
    }

    private void NewGameObject()
    {
        _id += 1;
        CurrentGameObject = Instantiate(myGameObject, startPosition, Quaternion.identity);
        CurrentGameObject.name = name + " " + _id;
    }

    private void CheckGameObject()
    {
        var gameObjectDestroyed = CurrentGameObject == null;
        if (!gameObjectDestroyed || LossManager.Lost) return;
        NewGameObject();
    }
}