using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        Door.GetComponent<Door>().keyNumber++;

        Destroy(gameObject);
    }

}
