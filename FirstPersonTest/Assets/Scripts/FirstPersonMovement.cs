using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    //Public floats
    public float moveSpeed = 5;
    public float jumpStrength = 10;
    public float rotationSpeed;
    public float bulletForce;

    //
    Rigidbody rb;

    //
    public Transform firePoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate player
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotationSpeed);

        // Player movement
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate((Input.GetAxis("Horizontal")) * Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate((Input.GetAxis("Vertical")) * Vector3.forward * moveSpeed * Time.deltaTime);
        }
        //Player jump force
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);  
        }


        //Shoot a bullet
        if (Input.GetButtonDown("Fire1"))
        {
           GameObject b = Instantiate(bullet, firePoint.position, firePoint.rotation);
           b.GetComponent<Rigidbody>().AddForce(firePoint.forward * bulletForce,ForceMode.Impulse);
        }
    }
}
