
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField]
    private float tocdo = 100f;

    [SerializeField]
    private float lucrexe = 100f;

    [SerializeField]
    private float lucphanh = 50f;

    private float dauvaodichuyen;
    private float dauvaore;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        dauvaodichuyen = Input.GetAxis("Vertical");
        dauvaore = Input.GetAxis("Horizontal");

        dichuyenxe();
        rexe();

        if (dauvaodichuyen > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            phanhxe();
        }
    }

    public void dichuyenxe()
    {
        rb.AddRelativeForce(Vector3.forward * dauvaodichuyen * tocdo);
    }

    public void rexe()
    {
        Quaternion re = Quaternion.Euler(
            Vector3.up * dauvaore * lucrexe * Time.deltaTime
        );

        rb.MoveRotation(rb.rotation * re);
    }

    public void phanhxe()
    {
        if (rb.velocity.z != 0)
        {
            rb.AddRelativeForce(-Vector3.forward * lucphanh);
        }
    }
}
