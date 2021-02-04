using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraControl : MonoBehaviour
{
    /// <summary>
    /// The tilt of the Camera in degrees
    /// </summary>
    float pitch = 0;
    float targetPitch = 0;

    /// <summary>
    /// The yaw angle of the camera rig in degrees
    /// </summary>
    float yaw = 0;
    float targetYaw = 0;

    /// <summary>
    /// How far away the camera should be from its target, by meters
    /// </summary>
    float dollyDis = 10;
    float targetDollyDis = 10;

    /// <summary>
    /// This scales the horizontal mouse input
    /// </summary>
    public float mouseSensitivityX;
    /// <summary>
    /// This scales the vertical mouse input
    /// </summary>
    public float mouseSensitivityY;

    public float mouseScrollMultiplier = 5;

    public float minDistance = 3f;
    public float maxDistance = 15f;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            // Changing the pitch
            float mouseY = Input.GetAxis("Mouse Y");
            float mouseX = Input.GetAxis("Mouse X");

            targetPitch += mouseY * mouseSensitivityY;
            targetYaw += mouseX * mouseSensitivityX;
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");
        targetDollyDis += scroll * mouseScrollMultiplier;
        targetDollyDis = Mathf.Clamp(targetDollyDis, minDistance, maxDistance);

        dollyDis = AnimMath.Slide(dollyDis, targetDollyDis, .05f); // EASE
        cam.transform.localPosition = new Vector3(0, 0, -dollyDis);


        // Changing the rotation to match the pitch variable

        targetPitch = Mathf.Clamp(targetPitch, -89, 89);

        pitch = AnimMath.Slide(pitch, targetPitch, .05f); //EASE
        yaw = AnimMath.Slide(yaw, targetYaw, .05f); //EASE

        // Quaternion targetRotation
        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.01f); // Could use .Slerp
    }

    public void changeMinMaxDist(int size)
    {
        if (size == 1)
        {
            minDistance = 3f;
            maxDistance = 15f;
            mouseScrollMultiplier = 6;
        }
        if (size == 2)
        {
            minDistance = 5f;
            maxDistance = 30f;
            mouseScrollMultiplier = 10;
        }
        if (size == 3)
        {
            minDistance = 10f;
            maxDistance = 175f;
            mouseScrollMultiplier = 45;
        }
    }
}
