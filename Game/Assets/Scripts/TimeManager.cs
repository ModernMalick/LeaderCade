using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Text text;
    
    [Header("VARIABLES")]
    [SerializeField] private float timeIncrements;
    
    private float _remainingTime;

    private void Start()
    {
        _remainingTime = timeIncrements;
    }

    private void Update()
    {
        if (_remainingTime <= 0)
        {
            Debug.Log("LOST");
            return;
        }
        _remainingTime -= Time.deltaTime;
        text.text = _remainingTime.ToString("F0");
    }

    public void AddTime()
    {
        _remainingTime += timeIncrements;
    }
}
