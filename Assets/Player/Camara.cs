using UnityEngine;


public class Camara : MonoBehaviour
{
    [Header("Camera Settings")]
    public float cameraSpeed = .2f;
    public Transform cameraTransform;
    public float clampAngle = 50f;
    private float xRotation = 0f;
    private Vector3 initialCamLocalPos;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (cameraTransform != null)
            initialCamLocalPos = cameraTransform.localPosition;
    }
    private void Update()
    {
        HandleMouseLook();
    }
    private void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * cameraSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * cameraSpeed;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -clampAngle, clampAngle);

        if (cameraTransform != null)
        {
            cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        }

        transform.Rotate(Vector3.up * mouseX);
    }
}