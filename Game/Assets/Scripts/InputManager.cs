using System;
using Objects.Ball;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    [HideInInspector] public GameObject gameObjectTouched;
    private Camera _camera;

    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        _camera = Camera.main;
    }

    private void Start()
    {
        BallCollisionManager.OnScoring += ResetTouch;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ResetTouch();
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Update()
    {
        if(LossManager.Lost) return;
        CheckTouch();
    }

    private void CheckTouch()
    {
        if (Pointer.current == null) return;
        if (!Pointer.current.press.wasPressedThisFrame) return;
        var touchPosition = Pointer.current.position.ReadValue();
        var ray = _camera.ScreenPointToRay(touchPosition);
        var touchedObject = !Physics.Raycast(ray, out var hit) ? null : hit.collider.gameObject;
        if (touchedObject == null || !touchedObject.CompareTag("Target")) return;
        gameObjectTouched = touchedObject;
    }

    private void ResetTouch()
    {
        gameObjectTouched = null;
    }
}