using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;
    public float distance = 5.0f;

    private float currentX = 0.0f;
    private float currentY = 20.0f;
    //private float sensitivityX = 20.0f;
    //private float sensitivityY = 20.0f;
    public float height = 2.0f;
    public float heightDamping = 2.0f;
    public float rotationDamping = 3.0f;
    public float f = -1.0f;

    private void Start()
    {
        camTransform = transform;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        // Unity provided script (found from forum) for "smooth follow"
        float wantedRotationAngle = lookAt.eulerAngles.y;
        float wantedHeight = lookAt.position.y + height;

        float currentRotationAngle = camTransform.eulerAngles.y;
        float currentHeight = camTransform.position.y;

        // Damp the rotation around the y-axis
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime * f);

        // Damp the height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Convert the angle into a rotation
        var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        // Set the position of the camera on the x-z plane to:
        // distance meters behind the target
        camTransform.position = lookAt.position;
        camTransform.position -= currentRotation * Vector3.forward * distance;

        // Set the height of the camera
        camTransform.position = new Vector3(camTransform.position.x, currentHeight, camTransform.position.z);

        camTransform.LookAt(lookAt);
    }
}
