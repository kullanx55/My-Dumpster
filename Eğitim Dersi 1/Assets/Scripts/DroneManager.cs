using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneManager : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject droneCamera;

    public GameObject tpsPlayer;

    public Rigidbody droneRB;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerCamera.activeSelf == true)
            {
                droneCamera.SetActive(true);
                playerCamera.SetActive(false);
                tpsPlayer.SetActive(false);
            }
            else if (playerCamera.activeSelf == false)
            {
                droneCamera.SetActive(false);
                playerCamera.SetActive(true);
                tpsPlayer.SetActive(true);
            }

        }

    }
}
