using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour
{
    int invertMouseY = -1;
    float mouseSensitivity = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, Input.GetAxis("Mouse X")* mouseSensitivity, 0); ;
        Camera head = GetComponentInChildren<Camera>();
        head.transform.localRotation = head.transform.localRotation * Quaternion.Euler(invertMouseY * Input.GetAxis("Mouse Y")* mouseSensitivity, 0, 0);
    }

}
