using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private Camera _camera;
    
    [HideInInspector] public GameObject gameObjectTouched;
    [HideInInspector] public bool touched;

    private void Awake()
    {
        _camera = Camera.main;
        gameObjectTouched = null;
    }

    private void Update()
    {
        CheckTouch();
        ResetTouch();
        SetCheck();
    }

    private void SetCheck()
    {
        if(!touched) return;
        var touchPosition = Pointer.current.position.ReadValue();
        var ray = _camera.ScreenPointToRay(touchPosition);
        gameObjectTouched = !Physics.Raycast(ray, out var hit) ? null : hit.collider.gameObject;
    }

    private void CheckTouch()
    {
        if(Pointer.current == null) return;
        if (Pointer.current.press.wasPressedThisFrame)
        {
            touched = true;
        }
    }

    private void ResetTouch()
    {
        if (touched) return;
        gameObjectTouched = null;
    }
}
