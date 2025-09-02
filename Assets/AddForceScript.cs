using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PushUp();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            RotateRB();
        }
    }

    void PushUp()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    void RotateRB()
    {
        rb.AddTorque(Vector3.up * force, ForceMode.Impulse);
    }
}
