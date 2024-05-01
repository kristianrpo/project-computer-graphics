using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float translationSpeed = 5f;
    public float rotationSpeed = 200f;

    void Update()
    {
        float xTranslate = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1 : 0;
        float yTranslate = Input.GetKey(KeyCode.S) ? -1 : Input.GetKey(KeyCode.W) ? 1 : 0;
        float zTranslate = Input.GetKey(KeyCode.Q) ? -1 : Input.GetKey(KeyCode.E) ? 1 : 0;

        float xRotationInput = Input.GetKey(KeyCode.X)? 10 : Input.GetKey(KeyCode.C)? -10 : 0;
        float yRotationInput = Input.GetKey(KeyCode.Y)? 10 : Input.GetKey(KeyCode.H)? -10 : 0;
        float zRotationInput = Input.GetKey(KeyCode.Z)? 10 : Input.GetKey(KeyCode.V)? -10 : 0;

        Vector3 translationVector = new Vector3(xTranslate, yTranslate, zTranslate) * translationSpeed * Time.deltaTime;
        transform.Translate(translationVector, Space.Self);

        transform.Rotate(Vector3.right, xRotationInput * rotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.up, yRotationInput * rotationSpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward, zRotationInput * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
