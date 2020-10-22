using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{


    public float sensitivity;
    public GameObject drone;
    public GameObject droneCamera;
    //Vector3 x, y, z;

    public Rigidbody droneRB;
    public float speed = 10;

    void Update()
    {

        droneRB.constraints = RigidbodyConstraints.FreezeRotation;

        if (droneCamera.activeSelf)
        {
            float rotateHorizontal = Input.GetAxis("Mouse X");
            float rotateVertical = Input.GetAxis("Mouse Y");
            transform.RotateAround(drone.transform.position, Vector3.up, rotateHorizontal * sensitivity);
        }

        if (droneCamera.activeSelf == true)
        {

            if (Input.GetKey(KeyCode.W))
            {
                Vector3 v3force = speed * transform.forward;
                droneRB.AddForce(v3force);
            }
            if (Input.GetKey(KeyCode.S))
            {
                Vector3 v3force = speed * -transform.forward;
                droneRB.AddForce(v3force);
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 v3force = speed * transform.right;
                droneRB.AddForce(v3force);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Vector3 v3force = speed * -transform.right;
                droneRB.AddForce(v3force);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Vector3 v3force = speed * transform.up;
                droneRB.AddForce(v3force);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Vector3 v3force = speed * -transform.up;
                droneRB.AddForce(v3force);
            }


            /*
            x = transform.right * Input.GetAxisRaw("Horizontal");
            z = transform.forward * Input.GetAxisRaw("Vertical");

            Vector3 movement = (x + z).normalized * speed;
            droneRB.AddForce(movement);
            */

        }
    }
}
