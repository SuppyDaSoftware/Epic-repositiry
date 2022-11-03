using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, Input.GetAxis("Mouse Y") * -rotationSpeed);
        //transform.rotation = Quaternion.Euler(Mathf.Clamp(transform.rotation.x, -90, 90), transform.eulerAngles.y, transform.eulerAngles.z);//
    }
}
