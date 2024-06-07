using UnityEngine;

public class PointLocation : MonoBehaviour
{
    private Camera _camera;
    private bool   _hasKeyCamera;

    void Start()
    {
        _camera = Camera.main;
        if (_camera != null)
        {
            _hasKeyCamera = true;
        }
        else
        {
            Debug.LogError("Camera.main is null");
            _hasKeyCamera = false;
        }
    }

    void LateUpdate()
    {
        if (_hasKeyCamera && IsMouseInScreenBounds()) { MoveToMouse(); }
    }

    private bool IsMouseInScreenBounds()
    {
        Vector3 mousePosition = Input.mousePosition;
        return mousePosition.x >= 0 && mousePosition.x <= Screen.width && mousePosition.y >= 0 && mousePosition.y <= Screen.height;
    }

    private void MoveToMouse()
    {
        Vector3 mousePos  = Input.mousePosition;
        Vector3 targetPos = _camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
        transform.position = targetPos;
    }
}