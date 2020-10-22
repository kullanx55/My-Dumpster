using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asansör : MonoBehaviour
{
    public Animator asansor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            asansor.SetBool("Working", true);
        }
    }
}
