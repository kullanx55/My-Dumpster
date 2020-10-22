using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public Rigidbody grenadeRB;


    private void Awake()
    {
        grenadeRB.AddForce(transform.forward * 500 + transform.up * 500);

    }


}
