using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rotate the object around its local Y axis at a user defined degree per second
// while running the application, the user can change the rotation speed using the arrow keys
// the rotation speed is clamped between -360 and 360 degrees per second
// the rotation direction is reversed when the rotation speed changes sign
// (e.g. from positive to negative or negative to positive)
// the rotation speed is reset to zero when the user presses the space bar
// the step size for changing the rotation speed is 36 degrees per second
// the rotation speed is displayed in the game window using OnGUI()

public class RotateCube : MonoBehaviour
{
    public float rotationSpeed = 0.0f;
    public float stepSize = 5.0f;
    public float maxRotationSpeed = 360.0f;
    public float minRotationSpeed = -360.0f;
    public float rotationDirection = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationSpeed += stepSize;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationSpeed -= stepSize;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rotationSpeed = 0.0f;
        }
        if (rotationSpeed == 0.0f)
        {
            rotationDirection = 0.0f;
        }
        if (rotationSpeed > maxRotationSpeed)
        {
            rotationSpeed = maxRotationSpeed;
        }
        if (rotationSpeed < minRotationSpeed)
        {
            rotationSpeed = minRotationSpeed;
        }
        if (rotationSpeed != 0.0f)
        {
            rotationDirection = rotationSpeed / Mathf.Abs(rotationSpeed);
        }
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime );
    }
}
