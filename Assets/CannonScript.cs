using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] Transform firePointTR;
    [SerializeField] GameObject bullet;
    [SerializeField] float shootingForce;

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * x * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletClone = Instantiate(bullet, firePointTR.position, transform.rotation);
            bulletClone.GetComponent<Rigidbody>().AddForce(Vector3.up * shootingForce, ForceMode.Impulse);
        }
    }
}
