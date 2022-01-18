using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [HideInInspector] public GameObject gameObjectTouched;
    [HideInInspector] public bool touched;
    private Camera _camera;

    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        _camera = Camera.main;
        gameObjectTouched = null;
    }

    private void Update()
    {
        if(LossManager.Lost) return;
        CheckTouch();
        ResetTouch();
        SetTouched();
    }

    private void SetTouched()
    {
        if (!touched) return;
        var touchPosition = Pointer.current.position.ReadValue();
        var ray = _camera.ScreenPointToRay(touchPosition);
        var touchedObject = !Physics.Raycast(ray, out var hit) ? null : hit.collider.gameObject;
        if (touchedObject == null || !touchedObject.CompareTag("Target")) return;
        gameObjectTouched = touchedObject;
    }

    private void CheckTouch()
    {
        if (Pointer.current == null) return;
        if (Pointer.current.press.wasPressedThisFrame) touched = true;
    }

    private void ResetTouch()
    {
        if (touched) return;
        gameObjectTouched = null;
    }
}