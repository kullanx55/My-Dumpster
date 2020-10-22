using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingCamera : MonoBehaviour
{
    public Transform ball;

    void Update()
    {
        this.gameObject.transform.LookAt(ball);
    }
}
