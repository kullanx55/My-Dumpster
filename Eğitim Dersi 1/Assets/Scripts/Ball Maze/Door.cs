using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int keyNumber = 0;


    private void OnCollisionEnter(Collision collision)
    {

        if (keyNumber == 1)
        {
            Destroy(gameObject);
        }
    }
}
